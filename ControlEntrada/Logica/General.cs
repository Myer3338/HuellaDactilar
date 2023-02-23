using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class General
    {//SqlConexion, se utiliza para conectarnos a la base de datos
        public static SqlConnection conexion = new SqlConnection(Datos.ConexionBD.cadenaconexion);

        public static void VerificarConexion()
        { try 
            { 
                conexion.Open();
                MessageBox.Show("Conexion Valida", "Felicitaciones");
            } 
            catch (Exception e) 
            {
                MessageBox.Show("Conexion Invalida" + e.Message.ToString(), "Error");
            }
            finally
            { 
                conexion.Close(); 
            }
        }
    }
}
