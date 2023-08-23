using System;
using System.Windows.Forms;

namespace Usuarios.Presentacion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            lblFiltroNombre.Visible = false;
            txtFiltroNombre.Visible = false;
            lblFiltroApellido.Visible = false;
            txtFiltroApellido.Visible = false;
            lblFiltroNumDoc.Visible = false;
            txtFiltroNumDoc.Visible = false;
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNombre.Checked)
            {
                lblFiltroNombre.Visible = true;
                txtFiltroNombre.Visible = true;
                lblFiltroApellido.Visible = false;
                txtFiltroApellido.Visible = false;
                lblFiltroNumDoc.Visible = false;
                txtFiltroNumDoc.Visible = false;
            }
        }

        private void rdbApellidos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbApellidos.Checked)
            {
                lblFiltroApellido.Visible = true;
                txtFiltroApellido.Visible = true;
                lblFiltroNombre.Visible = false;
                txtFiltroNombre.Visible = false;
                lblFiltroNumDoc.Visible = false;
                txtFiltroNumDoc.Visible = false;
            }
        }

        private void rdbNumDocumento_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNumDocumento.Checked)
            {
                lblFiltroNumDoc.Visible = true;
                txtFiltroNumDoc.Visible = true;
                lblFiltroNombre.Visible = false;
                txtFiltroNombre.Visible = false;
                lblFiltroApellido.Visible = false;
                txtFiltroApellido.Visible = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblFiltroNombre.Visible = false;
            txtFiltroNombre.Visible = false;
            lblFiltroApellido.Visible = false;
            txtFiltroApellido.Visible = false;
            lblFiltroNumDoc.Visible = false;
            txtFiltroNumDoc.Visible = false;
        }
    }
}
