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
    public partial class ModuloUsuarios : Form
    {
        public ModuloUsuarios()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            this.BNuevo.Enabled = false;
            this.BGuardar.Enabled = true;
            this.BCancelar.Enabled = true;
            this.BEliminar.Enabled = false;
            this.BEditar.Enabled = false;
            this.Buscar.Enabled = false;
            this.BBuscar.Enabled = false;
            this.BTodosRegistros.Enabled = false;
            this.groupBox2.Enabled = true;
            this.BFoto.Enabled = true;
            this.BEliminarFoto.Enabled = true;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            this.BNuevo.Enabled = true;
            this.BGuardar.Enabled = false;
            this.BCancelar.Enabled = false;
            this.BEliminar.Enabled = true;
            this.BEditar.Enabled = true;
            this.Buscar.Enabled = true;
            this.BBuscar.Enabled = true;
            this.BTodosRegistros.Enabled = true;
            this.groupBox2.Enabled = false;
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            this.BNuevo.Enabled = false;
            this.BGuardar.Enabled = true;
            this.BCancelar.Enabled = true;
            this.BEliminar.Enabled = false;
            this.BEditar.Enabled = false;
            this.Buscar.Enabled = false;
            this.BBuscar.Enabled = false;
            this.BTodosRegistros.Enabled = false;
            this.groupBox2.Enabled = true;
            this.BFoto.Enabled = true;
            this.BEliminarFoto.Enabled = true;
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.BNuevo.Enabled = true;
            this.BGuardar.Enabled = false;
            this.BCancelar.Enabled = false;
            this.BEliminar.Enabled = true;
            this.BEditar.Enabled = true;
            this.Buscar.Enabled = true;
            this.BBuscar.Enabled = true;
            this.BTodosRegistros.Enabled = true;
            this.groupBox2.Enabled = false;
            this.BFoto.Enabled = false;
            this.BEliminarFoto.Enabled = false;
        }
    }
}
