using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Usuarios.Datos.Data;
using Usuarios.Entidades;
using Usuarios.Negocio;

namespace Usuarios.Presentacion
{
    public partial class Usuario : Form
    {
        Operaciones operaciones = new Operaciones();
        private string IdUsuario = null;
        private bool Editar = false;
        private bool modo_modificar = false;
        bool respuesta = false;

        public Usuario(Persona ParametroPersona)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;

            if (ParametroPersona != null)
            {
                //lblTitulo.Text = "Modificar Registro";
                modo_modificar = true;
                txtIdUsuario.Text = ParametroPersona.IdUsuario.ToString();                
                txtNombre.Text = ParametroPersona.Nombres.ToString();
                txtApellidos.Text = ParametroPersona.Apellidos.ToString();
                txtEdad.Text = ParametroPersona.Edad.ToString();
                txtNumDocumento.Text = ParametroPersona.NumeroDocumento.ToString();
                CboDepartamento.DataSource = new Operaciones().ObtenerDepartamentos();
                CboDepartamento.ValueMember = "CodigoDane";
                CboDepartamento.DisplayMember = "Departamento";
                Departamentos oDepartamentoSeleccionado = CboDepartamento.SelectedItem as Departamentos;
                CboCiudad.DataSource = new Operaciones().ObtenerMunicipios(oDepartamentoSeleccionado.CodigoDane);
                CboCiudad.ValueMember = "IdMunicipio";
                CboCiudad.DisplayMember = "Municipio";
                txtDireccion.Text = ParametroPersona.Direccion.ToString();
                txtTelefono.Text = ParametroPersona.Telefono.ToString();
                txtCelular.Text = ParametroPersona.Celular.ToString();
                txtCorreo.Text = ParametroPersona.Correo.ToString();
                txtOcupacion.Text = ParametroPersona.Ocupacion.ToString();
            }
            else
            {
                txtIdUsuario.Text = "0";
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ListarDepartamentos();
            ListarTipoDocumento();
            //MostrarUsuarios();
            lblFiltroNombre.Visible = false;
            txtFiltroNombre.Visible = false;
            lblFiltroApellido.Visible = false;
            txtFiltroApellido.Visible = false;
            lblFiltroNumDoc.Visible = false;
            txtFiltroNumDoc.Visible = false;
        }

        //private void MostrarUsuarios()
        //{
        //    List<UsuarioViewModel> oListarUsuarios = new Operaciones().ObtenerUsuarios();

        //    dgvUsuarios.DataSource = null;
        //    dgvUsuarios.Columns.Clear();
        //    dgvUsuarios.Rows.Clear();
        //    dgvUsuarios.Refresh();
        //    dgvUsuarios.DataSource = oListarUsuarios;
        //    dgvUsuarios.Columns["IdUsuario"].Visible = true;
        //    dgvUsuarios.Columns["Activo"].Visible = false;
        //}

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
            lblFiltroNombre.Visible = false;
            txtFiltroNombre.Visible = false;
            lblFiltroApellido.Visible = false;
            txtFiltroApellido.Visible = false;
            lblFiltroNumDoc.Visible = false;
            txtFiltroNumDoc.Visible = false;
            RdbApellidos.Checked = false;
            RdbNombre.Checked = false;
            RdbNumDocumento.Checked = false;
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
            Persona persona = new Entidades.Persona
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
                    //MostrarUsuarios();
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
                    //MostrarUsuarios();
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
                UsuariosN usuariosN = new UsuariosN();
                usuariosN.Eliminar(Convert.ToInt32(IdUsuario).ToString());
                MessageBox.Show("Eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MostrarUsuarios();
            }
            else
            {
                MessageBox.Show("Seleccione la fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Usuario formUsuario = new Usuario(null);
            formUsuario.ShowDialog();
            //MostrarUsuarios();
        }
    }
}
