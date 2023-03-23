using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEntrada
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void salirLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entrarLogin_Click(object sender, EventArgs e)
        {
            //General.VerificarConexion();
            if (string.IsNullOrEmpty(this.tbUsuarioLogin.Text))
            {
                MessageBox.Show("Por favor digite el usuario", "Notificación");
                this.tbUsuarioLogin.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.tbContraseñaLogin.Text))
                {
                    MessageBox.Show("Por favor digite la contraseña", "Notificación");
                    this.tbContraseñaLogin.Focus();
                }
                else
                {

                }
            }

        }
    }
}
