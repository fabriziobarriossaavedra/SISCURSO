using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.- Importar librerias
using System.Data;
using System.Data.SqlClient;

//2.- BOL requiere acceso de DAL
using DAL;

namespace BOL
{
    //3.- clase publica
    public class Clasificacion
    {
        //Instancia de la clase que nos brinda acceso a la BD
        DBAccess acceso = new DBAccess();

        //metodos (insertar, buscar, listar, actualizar, eliminar)
        public DataTable listarClasificaciones()
        {
            //a. crear una instancia (onjeto) de la clase datatable
            DataTable data = new DataTable();

            //B. abrir conexion
            acceso.abrirConexion();
            //C. obtener los datos (sobrecargas)
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM clasificaciones", acceso.GetConnection());

            //D. Trasladar los datos
            adapter.Fill(data);

            //E. cerrar conexion
            acceso.cerrarConexion();

            //f. retornar los datos al metodo
            return data;
        }
    }
}
