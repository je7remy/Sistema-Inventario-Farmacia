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
    public class CDProducto
    {
        private int dId_Producto, dId_Categoria, dExistencia;
        private string dNombre, dEstado, dMarca;
        private DateTime dFecha_De_Vencimiento;
        private string dRepresentacion_Grafica;
        private decimal dPrecio_De_Venta;

        public CDProducto(int pId_Producto, string pNombre, int pId_Categoria, string pEstado, string pMarca,
            DateTime pFecha_De_Vencimiento, string pRepresentacion_Grafica, int pExistencia, decimal pPrecio_De_Venta)
        {
            dId_Producto = pId_Producto;
            dNombre = pNombre;
            dId_Categoria = pId_Categoria;
            dEstado = pEstado;
            dMarca = pMarca;
            dFecha_De_Vencimiento = pFecha_De_Vencimiento;
            dRepresentacion_Grafica = pRepresentacion_Grafica;
            dExistencia = pExistencia;
            dPrecio_De_Venta = pPrecio_De_Venta;

        }
        
        public CDProducto() { }
       
        public int Id_Producto
        {
            get { return dId_Producto; }
            set { dId_Producto = value; }
        }

        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }

        public int Id_Categoria
        {
            get { return dId_Categoria; }
            set { dId_Categoria = value; }
        }

        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }

        public string Marca
        {
            get { return dMarca; }
            set { dMarca = value; }
        }

        public DateTime Fecha_De_Vencimiento
        {
            get { return dFecha_De_Vencimiento; }
            set { dFecha_De_Vencimiento = value; }
        }

        public string Representacion_Grafica
        {
            get { return dRepresentacion_Grafica; }
            set { dRepresentacion_Grafica = value; }
        }

        public int Existencia
        {
            get { return dExistencia; }
            set { dExistencia = value; }
        }

        public decimal Precio_De_Venta
        {
            get { return dPrecio_De_Venta; }
            set { dPrecio_De_Venta = value; }
        }

        public string Insertar(CDProducto objCDProducto)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = InventarioConexion.miconexion;
                SqlCommand sqlCommand = new SqlCommand("ProductoInsertar", sqlCon);
                sqlCon.Open();

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@pId_Producto", objCDProducto.Id_Producto);
                sqlCommand.Parameters.AddWithValue("@pNombre", objCDProducto.Nombre);
                sqlCommand.Parameters.AddWithValue("@pId_Categoria", objCDProducto.Id_Categoria);
                sqlCommand.Parameters.AddWithValue("@pEstado", objCDProducto.Estado);
                sqlCommand.Parameters.AddWithValue("@pMarca", objCDProducto.Marca);
                sqlCommand.Parameters.AddWithValue("@pFecha_De_Vencimiento", objCDProducto.Fecha_De_Vencimiento);
                sqlCommand.Parameters.AddWithValue("@pRepresentacion_Grafica", objCDProducto.Representacion_Grafica);
                sqlCommand.Parameters.AddWithValue("@pExistencia", objCDProducto.Existencia);
                sqlCommand.Parameters.AddWithValue("@pPrecio_De_Venta", objCDProducto.Precio_De_Venta);

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

        public string Actualizar(CDProducto objCDProducto)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = InventarioConexion.miconexion;
                SqlCommand sqlCommand = new SqlCommand("ProductoActualizar", sqlCon);
                sqlCon.Open();

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@pId_Producto", objCDProducto.Id_Producto);
                sqlCommand.Parameters.AddWithValue("@pNombre", objCDProducto.Nombre);
                sqlCommand.Parameters.AddWithValue("@pId_Categoria", objCDProducto.Id_Categoria);
                sqlCommand.Parameters.AddWithValue("@pEstado", objCDProducto.Estado);
                sqlCommand.Parameters.AddWithValue("@pMarca", objCDProducto.Marca);
                sqlCommand.Parameters.AddWithValue("@pFecha_De_Vencimiento", objCDProducto.Fecha_De_Vencimiento);
                sqlCommand.Parameters.AddWithValue("@pRepresentacion_Grafica", objCDProducto.Representacion_Grafica);
                sqlCommand.Parameters.AddWithValue("@pExistencia", objCDProducto.Existencia);
                sqlCommand.Parameters.AddWithValue("@pPrecio_De_Venta", objCDProducto.Precio_De_Venta);

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
       
       


        public DataTable ProductoConsultar(string miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = new InventarioConexion().dbconexion;
                    sqlCommand.Connection.Open();
                    sqlCommand.CommandText = "ProductoConsultar";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@pId_Producto", miparametro);
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





        public DataTable ProductoObtenerTodos()
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = new InventarioConexion().dbconexion;
                    sqlCommand.Connection.Open();
                    sqlCommand.CommandText = "SELECT * FROM Producto"; // Reemplaza ... con el nombre de tu tabla ...
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
