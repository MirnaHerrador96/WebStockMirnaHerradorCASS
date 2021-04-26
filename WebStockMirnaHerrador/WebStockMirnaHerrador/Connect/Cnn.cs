using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WebStockMirnaHerrador.Connect
{
    class Cnn
    {
        SqlConnection Connect = new SqlConnection();
        private string Server = "DESKTOP-SRF69U6\\SQLEXPRESS";
        private string DB_Name = "inventario";
        private bool Conn = false;

        public SqlConnection openConn()
        {
            try
            {
                string conexion = "Server=" + Server + ";Database=" + DB_Name + "; Integrated security = true";
                Connect.ConnectionString = conexion;
                Connect.Open();
                Conn = true;
                MessageBox.Show("Se ha establecido conexión con la base de datos");
            }
            catch(SqlException e)
            {
                MessageBox.Show("Error al intentar conectar la base de datos" + e);
            }
            return Connect;
        }
        public void closeConn()
        {
            if(Conn)
            {
                try
                {
                    Connect.Close();
                    Conn = false;
                }
                catch(SqlException e)
                {
                    MessageBox.Show("Error al intentar conectar la base de datos" + e);
                }
            }
        }
    }
}
