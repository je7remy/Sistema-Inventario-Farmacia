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
    public class CDEmpleado
    {
        private int dId_Empleado;
        private string dNombre, dApellido, dDireccion, dTelefono, dCedula, dEstado, dSexo, dCargo;
        private DateTime dFecha_Nac;




        public CDEmpleado(int pId_Empleado, string pNombre, string pApellido, string pDireccion, string pTelefono, DateTime pFecha_Nac, string pCedula, string pEstado, string pSexo, string pCargo)
        {
            dId_Empleado = pId_Empleado;
            dNombre = pNombre;
            dApellido = pApellido;
            dDireccion = pDireccion;
            dTelefono = pTelefono;
            dFecha_Nac = pFecha_Nac;
            dCedula = pCedula;
            dEstado = pEstado;
            dSexo = pSexo;
            dCargo = pCargo;
        }

        public CDEmpleado (){}

        public int Id_Empleado
        {
            get { return dId_Empleado; }
            set { dId_Empleado = value; }
        }

        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }

        public string Apellido
        {
            get { return dApellido; }
            set { dApellido = value; }
        }

        public string Direccion
        {
            get { return dDireccion; }
            set { dDireccion = value; }
        }

        public string Telefono
        {
            get { return dTelefono; }
            set { dTelefono = value; }
        }

        public DateTime Fecha_Nac
        {
            get { return dFecha_Nac; }
            set { dFecha_Nac = value; }
        }

        public string Cedula
        {
            get { return dCedula; }
            set { dCedula = value; }
        }

        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }

        public string Sexo
        {
            get { return dSexo; }
            set { dSexo = value; }
        }

        public string Cargo
        {
            get { return dCargo; }
            set { dCargo = value; }
        }

        public string Insertar(CDEmpleado objCDEmpleado)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = InventarioConexion.miconexion;
                SqlCommand sqlCommand = new SqlCommand("EmpleadoInsertar", sqlCon);
                sqlCon.Open();

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@pNombre", objCDEmpleado.Nombre);
                sqlCommand.Parameters.AddWithValue("@pApellido", objCDEmpleado.Apellido);
                sqlCommand.Parameters.AddWithValue("@pDireccion", objCDEmpleado.Direccion);
                sqlCommand.Parameters.AddWithValue("@pTelefono", objCDEmpleado.Telefono);
                sqlCommand.Parameters.AddWithValue("@pFecha_Nac", objCDEmpleado.Fecha_Nac);
                sqlCommand.Parameters.AddWithValue("@pCedula", objCDEmpleado.Cedula);
                sqlCommand.Parameters.AddWithValue("@pEstado", objCDEmpleado.Estado);
                sqlCommand.Parameters.AddWithValue("@pSexo", objCDEmpleado.Sexo);
                sqlCommand.Parameters.AddWithValue("@pCargo", objCDEmpleado.Cargo);

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

        public string Actualizar(CDEmpleado objCDEmpleado)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = InventarioConexion.miconexion;
                SqlCommand sqlCommand = new SqlCommand("EmpleadoActualizar", sqlCon);
                sqlCon.Open();

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@pId_Empleado", objCDEmpleado.Id_Empleado);
                sqlCommand.Parameters.AddWithValue("@pNombre", objCDEmpleado.Nombre);
                sqlCommand.Parameters.AddWithValue("@pApellido", objCDEmpleado.Apellido);
                sqlCommand.Parameters.AddWithValue("@pDireccion", objCDEmpleado.Direccion);
                sqlCommand.Parameters.AddWithValue("@pTelefono", objCDEmpleado.Telefono);
                sqlCommand.Parameters.AddWithValue("@pFecha_Nac", objCDEmpleado.Fecha_Nac);
                sqlCommand.Parameters.AddWithValue("@pCedula", objCDEmpleado.Cedula);
                sqlCommand.Parameters.AddWithValue("@pEstado", objCDEmpleado.Estado);
                sqlCommand.Parameters.AddWithValue("@pSexo", objCDEmpleado.Sexo);
                sqlCommand.Parameters.AddWithValue("@pCargo", objCDEmpleado.Cargo);

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

        public DataTable EmpleadoConsultar(string miparametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = new InventarioConexion().dbconexion;
                    sqlCommand.Connection.Open();
                    sqlCommand.CommandText = "EmpleadoConsultar";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@pId_Empleado", miparametro);
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



        public DataTable EmpleadoObtenerTodos()
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = new InventarioConexion().dbconexion;
                    sqlCommand.Connection.Open();
                    sqlCommand.CommandText = "SELECT * FROM Empleado"; // Reemplaza "Empleado" con el nombre de tu tabla de empleados
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
