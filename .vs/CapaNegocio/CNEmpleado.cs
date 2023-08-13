using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using CapaDatos;


namespace CapaNegocio
{
   public class CNEmpleado
    {


        public static string Insertar(int pId_Empleado, string pNombre, string pApellido, string pDireccion, string pTelefono, DateTime pFecha_Nac, string pCedula, string pEstado, string pSexo, string pCargo)
        {

            CDEmpleado objCDEmpleado = new CDEmpleado();

            objCDEmpleado.Id_Empleado = pId_Empleado;
            objCDEmpleado.Nombre = pNombre;
            objCDEmpleado.Estado = pEstado;
            objCDEmpleado.Apellido = pApellido;
            objCDEmpleado.Direccion = pDireccion;
            objCDEmpleado.Telefono = pTelefono;
            objCDEmpleado.Fecha_Nac = pFecha_Nac;
            objCDEmpleado.Cedula = pCedula;
            objCDEmpleado.Estado = pEstado;
            objCDEmpleado.Sexo = pSexo;
            objCDEmpleado.Cargo = pCargo;

            return objCDEmpleado.Insertar(objCDEmpleado);
        }//Fin del método Insertar


        public static string Actualizar(int pId_Empleado, string pNombre, string pApellido, string pDireccion, string pTelefono, DateTime pFecha_Nac, string pCedula, string pEstado, string pSexo, string pCargo)
        {

            CDEmpleado objCDEmpleado = new CDEmpleado();
            objCDEmpleado.Id_Empleado = pId_Empleado;
            objCDEmpleado.Nombre = pNombre;
            objCDEmpleado.Estado = pEstado;
            objCDEmpleado.Apellido = pApellido;
            objCDEmpleado.Direccion = pDireccion;
            objCDEmpleado.Telefono = pTelefono;
            objCDEmpleado.Fecha_Nac = pFecha_Nac;
            objCDEmpleado.Cedula = pCedula;
            objCDEmpleado.Estado = pEstado;
            objCDEmpleado.Sexo = pSexo;
            objCDEmpleado.Cargo = pCargo;

            return objCDEmpleado.Actualizar(objCDEmpleado);
        }//Fin del método Actualizar


        //Método utilizado para obtener un DataTable con todos los datos de la tabla 
        //correspondiente

        public DataTable EmpleadoObtenerTodos()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\C#\Sistema-Inventario-Farmacia\CapaDatos\DBInventario.mdf;
Integrated Security = True"; // Reemplaza esto con la cadena de conexión a tu base de datos
            string consulta = "SELECT * FROM Empleado"; // Reemplaza "tabla_empleados" con el nombre de tu tabla de empleados

            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(consulta, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                dt.Load(reader);
            }

            return dt;
        }

        public DataTable EmpleadoObtener(string miparametro)
        {
            CDEmpleado objCDProducto = new CDEmpleado();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objCDProducto.EmpleadoConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }

      
    }
}

