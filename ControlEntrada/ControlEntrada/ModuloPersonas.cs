﻿using Logica;
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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
            this.cedulaTextBox.Enabled = false;
            this.nombreTextBox.Enabled = false;
            this.primerApellidoTextBox.Enabled = false;
            this.segundoApellidoTextBox.Enabled = false;
            this.fichaTextBox.Enabled = false;
            this.fotoPictureBox.Enabled = false;
            this.personasTableAdapter.Fill(this.dataSet1.Personas);

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        //private void personasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.personasBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dataSet1);

        //}

        private void Personal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.dataSet1.Personas);

        }

        private void cedulaTextBox_TextChanged(object sender, EventArgs e)
        {
            Globales.SeleccionarDedo(this);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ModuloAgregarPersona agregarPersona = new ModuloAgregarPersona();
            agregarPersona.ShowDialog();
        }

        private void editarPersona_Click(object sender, EventArgs e)
        {
            ModuloEditarPersona editarPersona = new ModuloEditarPersona();
            editarPersona.ShowDialog();
        }

        private void EliminarPersona_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Globales.Ced))
            {
                MessageBox.Show("Por favor seleccione el registro a eliminar", "Notificacion");
            }
            else if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar registro",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                this.personasTableAdapter.EliminarPersonasByDocumento(Globales.Ced);

                MessageBox.Show("El registro se ha eliminado con exito", "Notificación");
            }
            Globales.Ced = string.Empty;
            this.personasTableAdapter.Fill(this.dataSet1.Personas);
        }

        private void personasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                Globales.Ced = (personasDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }
    }
}
