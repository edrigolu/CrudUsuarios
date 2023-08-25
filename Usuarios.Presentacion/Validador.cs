using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Usuarios.Presentacion
{
    public class Validador
    {
        public static bool SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }

        public static bool TextBoxVacios(TextBox textBox)
        {
            if (textBox.Text == string.Empty)
            {
                textBox.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidarCorreo(string pCorreo)
        {
            return pCorreo != null && pCorreo.Length > 0 & Regex.IsMatch(pCorreo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        }
    }
}
