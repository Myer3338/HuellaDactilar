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
    public partial class ModuloEditarPersona : Form
    {
        public ModuloEditarPersona()
        {
            InitializeComponent();
        }

        private void ModuloEditarPersona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.dataSet1.Personas);

        }
    }
}
