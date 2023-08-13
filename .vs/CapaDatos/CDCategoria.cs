using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace CapaDatos
{
   public class CDCategoria
    {
        //Indicamos como privadas las propiedades de la clase CNSuplidor
        //uso d para referirme al dato o propiedad
        private int dId_Categoria;
        private string dNombre, dDescripcion;



        //Constructor vacío de la clase
       
            
            public CDCategoria(int pId_Categoria, string pNombre, string pDescripcion)
            {
            dId_Categoria = pId_Categoria;
            dNombre = pNombre;
            dDescripcion = pDescripcion;
        } //fin del método constructor con parámetros

        public CDCategoria() { }

        #region metodos get y set
        public int Id_Categoria
        {
            get { return dId_Categoria; }
            set { dId_Categoria = value; }
        }

        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }

        public string Descripcion
        {
            get { return dDescripcion; }
            set { dDescripcion = value; }
        }
        #endregion

        public string Insertar(CDCategoria objCDCategoria)
        {
            string mensaje = "";
            //creamos un nuevo objeto de tipo SqlConnection
            SqlConnection sqlCon = new SqlConnection();
            //trataremos de hacer algunas operaciones con la tabla
            try
            {
                //asignamos a sqlCon la conexión con las base de datos a traves de la clase que creamos
                sqlCon.ConnectionString = InventarioConexion.miconexion;
                //Escribo el nombre del procedimiento almacenado que utilizaré, en este caso SuplidorInsertar
                SqlCommand micomando = new SqlCommand("CategoriaInsertar", sqlCon);
                sqlCon.Open(); //Abro la conexión

                //indico que se ejecutara un procedimiento almacenado
                micomando.CommandType = CommandType.StoredProcedure;

                /*Envío los parámetros al procedimiento almacenado.
                - Los nombres que aparece con el signo @ delante son los parámetros que hemos
                creado en el procedimiento almacenado de la base de datos y debemos escribirlos tal cual 
                aparecen en dicho procedimiento almacenado (respetar mayúsculas y mnúsculas).
                - Los nombres que aparecen al lado son las propiedades del objeto objSuplidor que se pasará 
                como parámetro con los valores deseados. Puede usarse como lo declaramos en la clase 
                (usando el prefijo ( d ), por ejemplo: dSuplidor, o bien , hacerlo como se declaran en los métodos Get y 
                Set.
                        */
                micomando.Parameters.AddWithValue("@pId_Categoria", objCDCategoria.Id_Categoria);
                micomando.Parameters.AddWithValue("@pNombre", objCDCategoria.Nombre);
                micomando.Parameters.AddWithValue("@pDescripcion", objCDCategoria.Descripcion);


                /*Ejecuto la instrucción. Si se devuelve el valor 1 significa que todo funcionó correctamente de lo
                 * contrario se devuelve el mensaje indicando que fue incorrecto.
                 */
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente!" :
                "No se pudo insertar correctamente los nuevos datos!";
            }
            catch (Exception ex) //Si ocurre algún error se captura y se muestra el mensaje
            {
                mensaje = ex.Message;
            }
            finally //Luego de realizar el proceso de forma correcta o no 
 {
                    //Cierro la conexión si está abierta
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
                    //Devuelvo el mensaje correspondiente de acuerdo a lo que haya resultado del comando
            return mensaje;
        }



        //método para actualizar los datos del Suplidor. Recibirá el objeto objSuplidor como parámetro
        public string Actualizar(CDCategoria objCDCategoria)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = InventarioConexion.miconexion;
                SqlCommand micomando = new SqlCommand("CategoriaActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pId_Categoria", objCDCategoria.Id_Categoria);
                micomando.Parameters.AddWithValue("@pNombre", objCDCategoria.Nombre);
                micomando.Parameters.AddWithValue("@pDescripcion", objCDCategoria.Descripcion);
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Datos actualizados correctamente!" :
 "No se pudo actualizar correctamente los datos!";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return mensaje;
        }


        //Método para consultar datos filtrados de la tabla. Se recibe el valor del parámetro
        public DataTable CategoriaConsultar(String miparametro)
        {
            DataTable dt = new DataTable(); //Se Crea DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                using (SqlCommand sqlCmd = new SqlCommand()) //Establecer el comando
                {
                    sqlCmd.Connection = new InventarioConexion().dbconexion; //Conexión que va a usar el comando
                    sqlCmd.Connection.Open(); //Se abre la conexión
                    sqlCmd.CommandText = "CategoriaConsultar"; //Nombre del Proc. Almacenado a usar
                    sqlCmd.CommandType = CommandType.StoredProcedure; //Se trata de un proc. almacenado
                    sqlCmd.Parameters.AddWithValue("@pId_Categoria", miparametro); //Se pasa el valor a buscar
                    leerDatos = sqlCmd.ExecuteReader(); //Llenamos el SqlDataReader con los datos resultantes
                    dt.Load(leerDatos); //Se cargan los registros devueltos al DataTable
                    sqlCmd.Connection.Close(); //Se cierra la conexión
                }
            }
            catch (Exception)
            {
                dt = null; //Si ocurre algun error se anula el DataTable
            }
            return dt; ////Se retorna el DataTable segun lo ocurrido arriba
        } //Fin del método MostrarConFiltro


        public DataTable CategoiaConsultarTodos()
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = new InventarioConexion().dbconexion;
                    sqlCommand.Connection.Open();
                    sqlCommand.CommandText = "SELECT * FROM Categoria"; // Reemplaza "categoria" con el nombre de tu tabla de empleados
                    leerDatos = sqlCommand.ExecuteReader();
                    dt.Load(leerDatos);
                    sqlCommand.Connection.Close();
                }
            }
            catch (Exception)
            {
                dt = null;
            }

            return dt;
        }


    }
}
    

