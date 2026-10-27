using MySql.Data.MySqlClient; //Permite utilizar las clases necesarias para la conexión a MySQL
using System;
using System.Collections.Generic; // Permite trabajar con colecciones de datos
using System.Linq; //Manipular las colecciones
using System.Text; //Trabaja con texto
using System.Threading.Tasks; //Permite realizar operaciones asíncronas

namespace Actividad_2__Interfaz_con_conexion_a_MySQL 
{
    internal class Conexion_BD //clase que se conecta a MySQL
    {
        //Guarda los datos de la colección a la base d edatos
        private string cadenaConexion =
           "Server=localhost;Port=3306;Database=emociones_libros;Uid=root;Pwd=Ingrese su contraseña;";

        // Método público que crea y devuelve un objeto de conexión a MySQL.
        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion); //crea y devuelve un objeto de conexión a MySQL
        }
    }
}