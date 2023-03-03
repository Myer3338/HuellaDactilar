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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerrar el programa?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
                {
                    frm.Close();
                }
            }
        }

        private void btnUsuariosSistema_Click(object sender, EventArgs e)
        {
            ModuloUsuarios usuarios = new ModuloUsuarios();
            usuarios.ShowDialog();
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            panel.Left = (Width - panel.Width) / 2;
            panel.Top = (Width - panel.Height) / 2;
        }
    }
}
