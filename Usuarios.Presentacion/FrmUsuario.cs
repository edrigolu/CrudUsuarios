using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Usuarios.Datos.Data;
using Usuarios.Entidades;
using Usuarios.Negocio;

namespace Usuarios.Presentacion
{
    public partial class FrmUsuario : Form
    {
        Operaciones operaciones = new Operaciones();
        UsuariosN usuariosN = new UsuariosN();
        private string IdUsuario = null;
        private bool Editar = false;
        bool respuesta = false;

        public FrmUsuario()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }



        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ListarDepartamentos();
            ListarTipoDocumento();
            MostrarUsuarios();
            LimpiarFiltros();
            lblFiltroNombre.Visible = false;
            txtFiltroNombre.Visible = false;
            lblFiltroApellido.Visible = false;
            txtFiltroApellido.Visible = false;
            lblFiltroNumDoc.Visible = false;
            txtFiltroNumDoc.Visible = false;
        }

        private void MostrarUsuarios()
        {
            List<PersonaViewModel> oListarUsuarios = new Operaciones().ObtenerUsuarios();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.Columns.Clear();
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Refresh();
            dgvUsuarios.DataSource = oListarUsuarios;
            dgvUsuarios.Columns["IdUsuario"].Visible = true;
            dgvUsuarios.Columns["Activo"].Visible = false;
        }

        private void ListarTipoDocumento()
        {
            CboTipoDocumento.DataSource = new Operaciones().ObtenerTipoDocumento();
            CboTipoDocumento.ValueMember = "IdTipoDocumento";
            CboTipoDocumento.DisplayMember = "TipoDocumento";
        }

        private void ListarDepartamentos()
        {
            CboDepartamento.DataSource = new Operaciones().ObtenerDepartamentos();
            CboDepartamento.ValueMember = "CodigoDane";
            CboDepartamento.DisplayMember = "Departamento";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();           
        }

        private void LimpiarFiltros()
        {
            lblFiltroNombre.Visible = false;
            txtFiltroNombre.Visible = false;
            lblFiltroApellido.Visible = false;
            txtFiltroApellido.Visible = false;
            lblFiltroNumDoc.Visible = false;
            txtFiltroNumDoc.Visible = false;
            RdbApellidos.Checked = false;
            RdbNombre.Checked = false;
            RdbNumDocumento.Checked = false;
            txtFiltroNumDoc.Text = string.Empty;
            txtFiltroNombre.Text = string.Empty;
            txtFiltroApellido.Text = string.Empty;
        }

        private void RdbNombre_Click(object sender, EventArgs e)
        {
            if (RdbNombre.Checked)
            {
                lblFiltroNombre.Visible = true;
                txtFiltroNombre.Visible = true;
                lblFiltroApellido.Visible = false;
                txtFiltroApellido.Visible = false;
                lblFiltroNumDoc.Visible = false;
                txtFiltroNumDoc.Visible = false;
            }
        }

        private void RdbApellidos_Click(object sender, EventArgs e)
        {
            if (RdbApellidos.Checked)
            {
                lblFiltroNombre.Visible = false;
                txtFiltroNombre.Visible = false;
                lblFiltroApellido.Visible = true;
                txtFiltroApellido.Visible = true;
                lblFiltroNumDoc.Visible = false;
                txtFiltroNumDoc.Visible = false;
            }
        }

        private void RdbNumDocumento_Click(object sender, EventArgs e)
        {
            if (RdbNumDocumento.Checked)
            {
                lblFiltroNombre.Visible = false;
                txtFiltroNombre.Visible = false;
                lblFiltroApellido.Visible = false;
                txtFiltroApellido.Visible = false;
                lblFiltroNumDoc.Visible = true;
                txtFiltroNumDoc.Visible = true;
            }
        }

        private void CboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Departamentos oDepartamentoSeleccionado = CboDepartamento.SelectedItem as Departamentos;
            CboCiudad.DataSource = new Operaciones().ObtenerMunicipios(oDepartamentoSeleccionado.CodigoDane);
            CboCiudad.ValueMember = "IdMunicipio";
            CboCiudad.DisplayMember = "Municipio";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona
            {
                IdUsuario = Convert.ToInt32(txtIdUsuario.Text.ToString()),
                Nombres = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Edad = txtEdad.Text,
                NumeroDocumento = txtNumDocumento.Text,
                IdTipoDocumento = Convert.ToInt32(CboTipoDocumento.SelectedValue),
                IdCiudadResidencia = Convert.ToInt32(CboCiudad.SelectedValue),
                IdDepartamentoResidencia = Convert.ToInt32(CboDepartamento.SelectedValue),
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Celular = txtCelular.Text,
                Correo = txtCorreo.Text,
                Ocupacion = txtOcupacion.Text,
                Activo = true
            };

            if (Editar == false)
            {
                try
                {
                    respuesta = new Operaciones().CrearUsuario(persona);
                    MessageBox.Show("Insertado  correctamente.", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    MostrarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    respuesta = new Operaciones().Modificar(persona);
                    MessageBox.Show("Modificado  correctamente.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    MostrarUsuarios();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtApellidos.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtDireccion.Clear();
            txtNombre.Clear();
            txtCelular.Clear();
            txtNumDocumento.Clear();
            txtOcupacion.Clear();
            txtTelefono.Clear();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                Editar = true;
                txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value.ToString();
                txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = dgvUsuarios.CurrentRow.Cells["Apellidos"].Value.ToString();
                txtEdad.Text = dgvUsuarios.CurrentRow.Cells["Edad"].Value.ToString();
                txtNumDocumento.Text = dgvUsuarios.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
                CboDepartamento.DataSource = new Operaciones().ObtenerDepartamentos();
                CboDepartamento.ValueMember = "CodigoDane";
                CboDepartamento.DisplayMember = "Departamento";
                Departamentos oDepartamentoSeleccionado = CboDepartamento.SelectedItem as Departamentos;
                CboCiudad.DataSource = new Operaciones().ObtenerMunicipios(oDepartamentoSeleccionado.CodigoDane);
                CboCiudad.ValueMember = "IdMunicipio";
                CboCiudad.DisplayMember = "Municipio";
                txtDireccion.Text = dgvUsuarios.CurrentRow.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = dgvUsuarios.CurrentRow.Cells["Telefono"].Value.ToString();
                txtCelular.Text = dgvUsuarios.CurrentRow.Cells["Celular"].Value.ToString();
                txtCorreo.Text = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
                txtOcupacion.Text = dgvUsuarios.CurrentRow.Cells["Ocupacion"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                IdUsuario = dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value.ToString();
                
                usuariosN.Eliminar(Convert.ToInt32(IdUsuario).ToString());
                MessageBox.Show("Eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarUsuarios();
            }
            else
            {
                MessageBox.Show("Seleccione la fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = false;
            worksheet = workbook.Sheets["Hoja1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Usuarios";
            // Cabeceras
            for (int i = 1; i < dgvUsuarios.Columns.Count + 1; i++)
            {
                if (i > 1 && i < dgvUsuarios.Columns.Count)
                {
                    worksheet.Cells[1, i] = dgvUsuarios.Columns[i - 1].HeaderText;
                }
            }
            // Valores
            for (int i = 0; i < dgvUsuarios.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvUsuarios.Columns.Count; j++)
                {
                    if (j > 0 && j < dgvUsuarios.Columns.Count - 1)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvUsuarios.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos de Excel|*.xlsx",
                Title = "Guardar archivo",
                FileName = "NombredeArchivoDefault"
            };
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                Console.WriteLine("Ruta en: " + saveFileDialog.FileName);
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
        }

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource= operaciones.FiltrarNombre(txtFiltroNombre.Text);
        }

        private void txtFiltroApellido_TextChanged(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = operaciones.FiltrarApellido(txtFiltroApellido.Text);
        }

        private void txtFiltroNumDoc_TextChanged(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = operaciones.FiltrarNumDocumento(txtFiltroNumDoc.Text);
        }
    }
}
