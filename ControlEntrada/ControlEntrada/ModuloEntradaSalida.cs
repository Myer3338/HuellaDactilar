using DPFP;
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
    public partial class ModuloEntradaSalida : Form
    {
        public ModuloEntradaSalida()
        {
            InitializeComponent();
            Data = new AppData();
        }
        private AppData Data;
        string cedula = string.Empty;

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ModuloEntradaSalida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.dataSet1.Personas);

        }
    }
}
