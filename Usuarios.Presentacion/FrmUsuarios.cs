using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Usuarios.Datos.Data;
using Usuarios.Entidades;
using Usuarios.Negocio;

namespace Usuarios.Presentacion
{
    public partial class FrmUsuarios : Form
    {
        readonly Operaciones operaciones = new Operaciones();
        private string idUsuario = null;
        private readonly bool Editar = false;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ListarDepartamentos();
            ListarTipoDocumento();
            MostrarUsuarios();
            lblFiltroNombre.Visible = false;
            txtFiltroNombre.Visible = false;
            lblFiltroApellido.Visible = false;
            txtFiltroApellido.Visible = false;
            lblFiltroNumDoc.Visible = false;
            txtFiltroNumDoc.Visible = false;
        }

        private void MostrarUsuarios()
        {
            List<UsuarioViewModel> oListarUsuarios = new Operaciones().ObtenerUsuarios();

            dgvUsuarios.DataSource = null;
            dgvUsuarios.Columns.Clear();
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Refresh();

            dgvUsuarios.DataSource = oListarUsuarios;
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
            Usuario usuario = new Usuario
            {
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

            var respuesta = false;
            if (Editar)
            {
                string mensajeOk = string.Empty;
                mensajeOk = "Se guardaron los cambios \n¿Desea hacer un nuevo registro?";
                respuesta = new Operaciones().Modificar(usuario);
                LimpiarFormulario();
                MostrarUsuarios();
            }
            else
            {
                string mensajeOk = string.Empty;
                mensajeOk = "Persona Registrada \n¿Desea hacer un nuevo registro?";
                respuesta = new Operaciones().CrearUsuario(usuario);
                LimpiarFormulario();
                MostrarUsuarios();
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

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                idUsuario = dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value.ToString();
                UsuariosN usuariosN = new UsuariosN();
                usuariosN.Eliminar(Convert.ToInt32(idUsuario).ToString());
                MessageBox.Show("Eliminado correctamente.");
                MostrarUsuarios();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor.");
            }
        }
    }
}
