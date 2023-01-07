using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.- Importando Librerias
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    //2.- establecer la clase como publica
    public class DBAccess
    {
        //3.- objeto de conexion a MSSQL SERVER
        SqlConnection conexion = new SqlConnection("data source=RFBS23\\SQLEXPRESS;database=senaticursos;user id=RFBS23\fabri;integrated security=true");

        //4.- metodos de acces
        public SqlConnection GetConnection()
        {
            return conexion;
        }

        //5.- abrir conexion
        public void abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        //6.- cerrar conexion
        public void cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
