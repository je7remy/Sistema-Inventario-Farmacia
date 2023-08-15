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
    public class CDMovimientoInventario
    {
        private int dId_Inventario, dId_Producto, dCantidad, dId_Empleado;
        private string dTipo_De_Movimiento;
        private DateTime dFecha;

        public CDMovimientoInventario(int pId_Inventario, int pId_Producto, int pCantidad, string pTipo_De_Movimiento, int pId_Empleado, DateTime pFecha)
        {
            dId_Inventario = pId_Inventario;
            dId_Producto = pId_Producto;
            dCantidad = pCantidad;
            dTipo_De_Movimiento = pTipo_De_Movimiento;
            dId_Empleado = pId_Empleado;
            dFecha = pFecha;
        }


        public CDMovimientoInventario() { }

        public int Id_Inventario
        {
            get { return dId_Inventario; }
            set { dId_Inventario = value; }
        }

        public int Id_Producto
        {
            get { return dId_Producto; }
            set { dId_Producto = value; }
        }

        public int Cantidad
        {
            get { return dCantidad; }
            set { dCantidad = value; }
        }

        public string Tipo_De_Movimiento
        {
            get { return dTipo_De_Movimiento; }
            set { dTipo_De_Movimiento = value; }
        }

        public int Id_Empleado
        {
            get { return dId_Empleado; }
            set { dId_Empleado = value; }
        }

        public DateTime Fecha
        {
            get { return dFecha; }
            set { dFecha = value; }
        }

        //public string Insertar(CDMovimientoInventario objCDMovimientoInventario)
        //{
        //    string mensaje = "";
        //    SqlConnection sqlCon = new SqlConnection();

        //    try
        //    {
        //        sqlCon.ConnectionString = InventarioConexion.miconexion;
        //        SqlCommand sqlCommand = new SqlCommand("MovimientoInventarioInsertar", sqlCon);
        //        sqlCon.Open();

        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.AddWithValue("@pId_Inventario", objCDMovimientoInventario.Id_Inventario);
        //        sqlCommand.Parameters.AddWithValue("@pId_Producto", objCDMovimientoInventario.Id_Producto);
        //        sqlCommand.Parameters.AddWithValue("@pCantidad", objCDMovimientoInventario.Cantidad);
        //        sqlCommand.Parameters.AddWithValue("@pTipo_De_Movimiento", objCDMovimientoInventario.Tipo_De_Movimiento);
        //        sqlCommand.Parameters.AddWithValue("@pId_Empleado", objCDMovimientoInventario.Id_Empleado);
        //        sqlCommand.Parameters.AddWithValue("@pFecha", objCDMovimientoInventario.Fecha);

        //        mensaje = sqlCommand.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente!" :
        //            "No se pudo insertar correctamente los nuevos datos!";
        //    }
        //    catch (Exception ex)
        //    {
        //        mensaje = ex.Message;
        //    }
        //    finally
        //    {
        //        if (sqlCon.State == ConnectionState.Open)
        //            sqlCon.Close();
        //    }

        //    return mensaje;
        //}
        public string Insertar(CDMovimientoInventario objCDMovimientoInventario)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = InventarioConexion.miconexion;
                SqlCommand sqlCommand = new SqlCommand("MovimientoInventarioInsertar", sqlCon);
                sqlCon.Open();

                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Parámetros del procedimiento almacenado
                sqlCommand.Parameters.AddWithValue("@pId_Inventario", objCDMovimientoInventario.Id_Inventario); // Agregar esta línea
                sqlCommand.Parameters.AddWithValue("@pId_Producto", objCDMovimientoInventario.Id_Producto);
                sqlCommand.Parameters.AddWithValue("@pCantidad", objCDMovimientoInventario.Cantidad);
                sqlCommand.Parameters.AddWithValue("@pTipo_De_Movimiento", objCDMovimientoInventario.Tipo_De_Movimiento);
                sqlCommand.Parameters.AddWithValue("@pId_Empleado", objCDMovimientoInventario.Id_Empleado);
                sqlCommand.Parameters.AddWithValue("@pFecha", objCDMovimientoInventario.Fecha);

                mensaje = sqlCommand.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente!" :
                    "No se pudo insertar correctamente los nuevos datos!";
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


        public string Actualizar(CDMovimientoInventario objCDMovimientoInventario)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = InventarioConexion.miconexion;
                SqlCommand sqlCommand = new SqlCommand("MovimientoInventarioActualizar", sqlCon);
                sqlCon.Open();

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@pId_Inventario", objCDMovimientoInventario.Id_Inventario);
                sqlCommand.Parameters.AddWithValue("@pId_Producto", objCDMovimientoInventario.Id_Producto);
                sqlCommand.Parameters.AddWithValue("@pCantidad", objCDMovimientoInventario.Cantidad);
                sqlCommand.Parameters.AddWithValue("@pTipo_De_Movimiento", objCDMovimientoInventario.Tipo_De_Movimiento);
                sqlCommand.Parameters.AddWithValue("@pId_Empleado", objCDMovimientoInventario.Id_Empleado);
                sqlCommand.Parameters.AddWithValue("@pFecha", objCDMovimientoInventario.Fecha);

                mensaje = sqlCommand.ExecuteNonQuery() == 1 ? "Datos actualizados correctamente!" :
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

        public DataTable MovimientoInventarioConsultar(string miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = new InventarioConexion().dbconexion;
                    sqlCommand.Connection.Open();
                    sqlCommand.CommandText = "SELECT* FROM Movimiento_Inventario";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@pId_Inventario", miparametro);
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


        public DataTable MovimientoInventarioConsultarTodos()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new InventarioConexion().dbconexion)
                {
                    connection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = connection;
                        sqlCommand.CommandText = "SELECT * FROM Movimiento_Inventario"; // Cambia esto a la consulta SQL adecuada
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        dt.Load(reader);

                        reader.Close();
                    }
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
