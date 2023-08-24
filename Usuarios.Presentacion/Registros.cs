using System.Collections.Generic;
using System.Windows.Forms;
using Usuarios.Datos.Data;
using Usuarios.Entidades;

namespace Usuarios.Presentacion
{
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BtnNuevo_Click(object sender, System.EventArgs e)
        {
            Usuario formUsuario = new Usuario(null);
            formUsuario.ShowDialog();
            MostrarUsuarios();
        }

        private void DiseñoInicial()
        {
            BtnNuevo.Cursor = Cursors.Hand;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void MostrarUsuarios()
        {
            List<UsuarioViewModel> oListarUsuarios = new Operaciones().ObtenerUsuarios();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.Columns.Clear();
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Refresh();
            dgvUsuarios.DataSource = oListarUsuarios;
            dgvUsuarios.Columns["IdUsuario"].Visible = true;
            dgvUsuarios.Columns["Activo"].Visible = false;
        }

        private void Registros_Load(object sender, System.EventArgs e)
        {
            DiseñoInicial();
            MostrarUsuarios();
        }
    }
}
