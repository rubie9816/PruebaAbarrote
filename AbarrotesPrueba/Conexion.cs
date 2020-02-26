using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbarrotesPrueba
{
    class Conexion
    {
        #region CONNECTIONSTRING
        private static SqlConnection miconexion = new SqlConnection(@"Data Source=DESKTOP-G9819I0\SQLEXPRESS01;Initial Catalog=ABARROTESLIZ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        #endregion

        public static DataSet ConsultaDatosStock()
        {
            string str = "select * from Producto";
            SqlCommand orden = new SqlCommand(str, miconexion);
            miconexion.Open();
            orden.ExecuteNonQuery();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = orden;
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "xxx");
            miconexion.Close();
            return ds;
        }

    }
}

