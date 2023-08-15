using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using CapaDatos;

namespace CapaNegocio
{
  public class CNMovimientoInventario
    {

        public static string Insertar(int pId_Inventario, int pId_Producto, int pCantidad, string pTipo_De_Movimiento, int pId_Empleado, DateTime pFecha)
        {
            CDMovimientoInventario objCDMovimientoInventario = new CDMovimientoInventario();

            objCDMovimientoInventario.Id_Inventario = pId_Producto;
            objCDMovimientoInventario.Id_Producto = pId_Producto;
            objCDMovimientoInventario.Cantidad = pCantidad;
            objCDMovimientoInventario.Tipo_De_Movimiento = pTipo_De_Movimiento;
            objCDMovimientoInventario.Id_Empleado = pId_Empleado;
            objCDMovimientoInventario.Fecha = pFecha;

            //mensaje = objCDMovimientoInventario.Insertar(objCDMovimientoInventario); // Cambio aquí

            return objCDMovimientoInventario.Insertar(objCDMovimientoInventario);
        }//Fin del método Insertar



        public static string Actualizar(int pId_Inventario, int pId_Producto, int pCantidad, string pTipo_De_Movimiento, int pId_Empleado, DateTime pFecha)
        {

            CDMovimientoInventario objCDMovimientoInventario = new CDMovimientoInventario();

            objCDMovimientoInventario.Id_Inventario = pId_Producto;
            objCDMovimientoInventario.Id_Producto = pId_Producto;
            objCDMovimientoInventario.Cantidad = pCantidad;
            objCDMovimientoInventario.Tipo_De_Movimiento = pTipo_De_Movimiento;
            objCDMovimientoInventario.Id_Empleado = pId_Empleado;
            objCDMovimientoInventario.Fecha = pFecha;


            return objCDMovimientoInventario.Actualizar(objCDMovimientoInventario);
        }//Fin del método Actualizar

        //Método utilizado para obtener un DataTable con todos los datos de la tabla 
        //correspondiente

        //public DataTable MovimientoInventarioConsultar(string miparametro)
        //{
        //    CDMovimientoInventario objCDMovimientoInventario = new CDMovimientoInventario();
        //    DataTable dt = new DataTable();

        //    try
        //    {
        //        using (SqlCommand sqlCommand = new SqlCommand())
        //        {
        //            sqlCommand.Connection = new InventarioConexion().dbconexion;
        //            sqlCommand.Connection.Open();
        //            sqlCommand.CommandText = "MovimientoInventarioConsultar";
        //            sqlCommand.CommandType = CommandType.StoredProcedure;
        //            sqlCommand.Parameters.AddWithValue("@pId_Inventario", miparametro);
        //          //  sqlCommand.Parameters.AddWithValue("@pId_Empleado", idEmpleado);
        //            SqlDataReader leerDatos = sqlCommand.ExecuteReader();
        //            dt.Load(leerDatos);
        //            sqlCommand.Connection.Close();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        dt = null;
        //    }

        //    return dt;
        //}
        public DataTable MovimientoInventarioConsultar(string valorparametro)
        {
            // Utiliza el INNER JOIN para relacionar el ID del empleado con los movimientos de inventario
            string query = @"
        SELECT MI.Id_Inventario, MI.Id_Producto, P.Nombre AS NombreProducto, MI.Cantidad, MI.Tipo_De_Movimiento,
               MI.Id_Empleado, E.Nombre AS NombreEmpleado, MI.Fecha
        FROM Movimiento_Inventario AS MI
        INNER JOIN Producto AS P ON MI.Id_Producto = P.Id_Producto
        INNER JOIN Empleado AS E ON MI.Id_Empleado = E.Id_Empleado
        WHERE E.Id_Empleado LIKE @valorparametro
        ORDER BY MI.Id_Inventario;
    ";

            // Ejecuta la consulta y devuelve el resultado en un DataTable
            // Utiliza un objeto SqlCommand y SqlDataAdapter para llenar el DataTable
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\C#\Sistema-Inventario-Farmacia\CapaDatos\DBInventario.mdf;
Integrated Security = True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@valorparametro", valorparametro);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }



        public DataTable MovimientoInventarioConsultar1(string miparametro)
        {
            CDMovimientoInventario objCDMovimientoInventario = new CDMovimientoInventario();
            DataTable dt = new DataTable();

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = new InventarioConexion().dbconexion;
                    sqlCommand.Connection.Open();
                    sqlCommand.CommandText = "MovimientoInventarioConsultar";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@pId_Inventario", miparametro);
                    //  sqlCommand.Parameters.AddWithValue("@pId_Empleado", idEmpleado);
                    SqlDataReader leerDatos = sqlCommand.ExecuteReader();
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


        public DataTable MovimientoInventarioConsultarTodos()
        {
            CDMovimientoInventario objCDMovimientoInventario = new CDMovimientoInventario();
            DataTable dt = new DataTable(); // Creamos un nuevo DataTable
                                            // El DataTable se llena con todos los datos devueltos
            dt = objCDMovimientoInventario.MovimientoInventarioConsultarTodos(); // Cambiamos el método para consultar todos los registros
            return dt; // Se retorna el DataTable con los datos adquiridos
        }


    }
}
