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

        public DataTable MovimientoInventarioConsultar(string miparametro)
        {
            CDMovimientoInventario objCDMovimientoInventario = new CDMovimientoInventario();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
          dt = objCDMovimientoInventario.MovimientoInventarioConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }



    }
}
