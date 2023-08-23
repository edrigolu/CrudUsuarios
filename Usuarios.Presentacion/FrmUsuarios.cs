using System;
using System.Windows.Forms;
using Usuarios.Datos.Data;
using Usuarios.Entidades;

namespace Usuarios.Presentacion
{
    public partial class FrmUsuarios : Form
    {
        readonly Operaciones  operaciones = new Operaciones();
        private readonly string idUsuario = null;
        private readonly bool Editar = false;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ListarDepartamentos();
            ListarTipoDocumento();
            lblFiltroNombre.Visible = false;
            txtFiltroNombre.Visible = false;
            lblFiltroApellido.Visible = false;
            txtFiltroApellido.Visible = false;
            lblFiltroNumDoc.Visible = false;
            txtFiltroNumDoc.Visible = false;
        }

        private void ListarTipoDocumento()
        {
            CboTipoDocumento.DataSource= new Operaciones().ObtenerTipoDocumento();
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
    }
}
