using Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEntrada
{
    public static class Globales
    {
        #region Varable
        public static int TipoCrud;
        public static string Ced;
        public static int PosicionRegistro;

        //

        public static string Id_usuario;
        public static byte Foto_usuario;
        public static string cedula_usuario;
        public static string Nombre_usuario;
        public static string correo_usuario;
        public static string usuario_usuario;
        public static string contrasena_usuario;
        public static string rol_usuario;
        #endregion

        #region Usuarios
        public static void VerificarRegisstros(ModuloUsuarios u) {

            General.VerificaExistenRegistros("Select Count(*) From Usuarios");
            if (Convert.ToInt32(General.cadena)>0)
            {
                General.BuscarRegistros("Select * From Usuarios");
                //LeerRegistrosUsuarios(u);
                u.groupBox2.Enabled = false;
                u.MovePreviousItem.Enabled = true;
                u.MoveFirstItem.Enabled = true;
                u.MovePreviousItem.Enabled = true;
                u.bindingNavigatorPositionItem.Enabled = true;
                u.bindingNavigatorCountItem.Enabled = true;
                u.MoveNextItem.Enabled = true;
                u.MoveLastItem.Enabled = true;
                u.BNuevo.Enabled = true;
                u.BGuardar.Enabled = false;
                u.BCancelar.Enabled = false;
                u.BEliminar.Enabled = true;
                u.BEditar.Enabled = true;
                u.Buscar.Enabled = true;
                u.BBuscar.Enabled = true;
                u.BTodosRegistros.Enabled = true;
            }
            else
            {
                u.groupBox2.Enabled = false;
                u.MovePreviousItem.Enabled = true;
                u.MoveFirstItem.Enabled = false;
                u.MovePreviousItem.Enabled = false;
                u.bindingNavigatorPositionItem.Enabled = false;
                u.bindingNavigatorCountItem.Enabled = false;
                u.MoveNextItem.Enabled = false;
                u.MoveLastItem.Enabled = false;
                u.BNuevo.Enabled = true;
                u.BGuardar.Enabled = false;
                u.BCancelar.Enabled = false;
                u.BEliminar.Enabled = false;
                u.BEditar.Enabled = false;
                u.Buscar.Enabled = false;
                u.BBuscar.Enabled = false;
            }

        }

        public static void GuardarUsuario(ModuloUsuarios u)
        {
            if (TipoCrud ==1) //insertar
            {
                General.InsertarActualizar("INSERT INTO Usuarios VALUES (@Foto, @Cedula, @Nombre, @Correo, @Usuario, @Contrasena, @Rol)",
                imageToByteArray(u.fotoPictureBox.Image),
                u.cedulaTextBox.Text,
                u.nombreTextEdit.Text,
                u.correoTextBox.Text,
                u.usuarioTtextBox.Text,
                u.contrasenaTextEdit.Text,
                u.rolComboBox.Text,
                TipoCrud);
                VerificarRegisstros(u);
            }

            if (TipoCrud == 2) //Actualizar
            {
                General.InsertarActualizar("UPDATE Usuarios Set Foto = @Foto," +
                    "Cedula = @Cedula," +
                    "Nombre = @Nombre," +
                    "Correo = @Correo," +
                    "Usuario = @Usuario," +
                    "Contrasena = @Contrasena," +
                    "Rol = @Rol Where IdUsuario = " + "'" + Convert.ToInt32(u.id_UsuarioTextBox.Text) + "'",
                imageToByteArray(u.fotoPictureBox.Image),
                u.cedulaTextBox.Text,
                u.nombreTextEdit.Text,
                u.correoTextBox.Text,
                u.usuarioTtextBox.Text,
                u.contrasenaTextEdit.Text,
                u.rolComboBox.Text,
                TipoCrud);
                //
                u.groupBox2.Enabled = false;
                u.MoveFirstItem.Enabled = true;
                u.MovePreviousItem.Enabled = true;
                u.bindingNavigatorPositionItem.Enabled = true;
                u.bindingNavigatorCountItem.Enabled = true;
                u.MoveNextItem.Enabled = true;
                u.MoveLastItem.Enabled = true;
                u.BNuevo.Enabled = true;
                u.BGuardar.Enabled = false;
                u.BCancelar.Enabled = false;
                u.BEliminar.Enabled = true;
                u.BEditar.Enabled = true;
                u.Buscar.Enabled = true;
                u.BBuscar.Enabled = true;
                u.BTodosRegistros.Enabled = true;
            }
        }
        
        public static void LeerRegistrosUsuarios(ModuloUsuarios u)
        {
            //Recorrer la tabla
            for (int i = 0; i < General.temporal.Rows.Count; i++)
            {
                //Llenamos la imagen y los textbox
                u.fotoPictureBox.Image = Globales.byteArrayToImage((Byte[])(General.temporal.Rows[i]["Foto"]));
                u.id_UsuarioTextBox.Text = General.temporal.Rows[i]["IdUsuario"].ToString();
                u.cedulaTextBox.Text = General.temporal.Rows[i]["Cedula"].ToString();
                u.nombreTextEdit.Text = General.temporal.Rows[i]["Nombre"].ToString();
                u.correoTextBox.Text = General.temporal.Rows[i]["Correo"].ToString();
                u.usuarioTtextBox.Text = General.temporal.Rows[i]["Usuario"].ToString();
                u.contrasenaTextEdit.Text = General.temporal.Rows[i]["Contrasena"].ToString();
                u.rolComboBox.Text = General.temporal.Rows[i]["Rol"].ToString();
            }
            u.UsuariosbindingSource.DataSource = General.temporal;
        }
        #endregion

        #region Imagenes
        //Convertir imagen a un array de bytes
        public static byte[] imageToByteArray(System.Drawing.Image imageIn) 
        {
            MemoryStream ms = new MemoryStream();
            try
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception)
            {
                //MessageBox.Show(e.Message);
            }
            return ms.ToArray();
        }

        //Convertir array de bytes a una imagen
        public static Image byteArrayToImage(byte[] byteArrayIn) 
        { 
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        #endregion
    }
}
