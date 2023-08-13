using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using CapaNegocio;


namespace Sistema_Inventario
{
    public partial class Movimiento_Inventario : Form
    {
        private int vtieneparametro;
        public string valorparametro = "", mensaje = "";
        public static int vId_Inventario = 0, Cantidad = 0;
        public static string Empleado, Tipo_De_Movimiento, Nombre, Representacion_Grafica;
        public static DateTime Fecha;
        public static string miconexion = "Data Source=HDX16T; Initial Catalog = DBInventario; Integrated Security = True;";



        public Movimiento_Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Busqueda_Producto busqueda_producto = new Busqueda_Producto();
            busqueda_producto.ShowDialog();

          
                RecuperaDatos(); //Llamo al método para recuperar el Depto seleccionado
               
           
                //Limpiar();
                //BBuscar.Focus();
            
        }

        private void Bcancelar_Click_1(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            Limpiar();
            BBuscar.Focus();
        }

        private void Movimiento_Inventario_Load(object sender, EventArgs e)
        {
            Program.nuevo = true;

            CNCategoria cncategoria = new CNCategoria();
            DataTable dtCategorias = cncategoria.CategoriaConsultarTodos();

            if (dtCategorias.Rows.Count > 0)
            {
                CCategoria.DataSource = dtCategorias;
                CCategoria.DisplayMember = "Nombre"; // Cambia esto al nombre de la columna de nombre de categoría
                CCategoria.ValueMember = "Id_Categoria"; // Cambia esto al nombre de la columna de ID de categoría
            }
            else
            {
                MessageBox.Show("No se encontraron categorías en la base de datos.");
            }

            CNEmpleado cnempleado = new CNEmpleado();
            DataTable dtempleado = cnempleado.EmpleadoObtenerTodos();

            if (dtempleado.Rows.Count > 0)
            {
                CCEmpleado.DataSource = dtempleado;
                CCEmpleado.DisplayMember = "Nombre"; // Cambia esto al nombre de la columna de nombre de categoría
                CCEmpleado.ValueMember = "Id_Empleado"; // Cambia esto al nombre de la columna de ID de categoría
            }
            else
            {
                MessageBox.Show("No se encontraron categorías en la base de datos.");
            }

        }

        private string ObtenerNombreCategoria(string idCategoria)
        {
            CNCategoria cncategoria = new CNCategoria();
            DataTable dt = cncategoria.CategoriaConsultar(idCategoria);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Nombre"].ToString();
            }

            return string.Empty;
        }

        private string ObtenerNombreEmpleado(string idEmpleado)
        {
            CNEmpleado cnempleado = new CNEmpleado();
            DataTable dtempleado = cnempleado.EmpleadoObtener(idEmpleado);

            if (dtempleado.Rows.Count > 0)
            {
                return dtempleado.Rows[0]["Nombre"].ToString();
            }

            return string.Empty;
        }

        private void Bguardar_Click(object sender, EventArgs e)
        
            {
            //Validamos los datos requeridos entes de Insertar o Actualizar
           
            if (TNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el ID del producto!");
                TNombre.Focus();
            }
            else
            if (CTipodemovimiento.Text == String.Empty)
            {
                MessageBox.Show("Debe seleccionar el tipo de movimiento!");
                CTipodemovimiento.Focus();
            }
            else
            if (TCantidad.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la cantidad del movimiento!");
                TCantidad.Focus();
            }
            else
            if (DFecha.Text == String.Empty)
            {
                MessageBox.Show("Debe seleccionar la fecha del movimiento!");
                DFecha.Focus();
            }
            else
            if (CCEmpleado.Text == String.Empty)
            {
                MessageBox.Show("Debe seleccionar el ID del Empleado!");
                CCEmpleado.Focus();
            }
            else

            {

                if (Program.nuevo) //Si la variable nuevo llega con valor true se van a Insertar nuevos datos

                {
                    int Id_ProdM = 0;
                    int.TryParse(TNombre.Text, out Id_ProdM);

                    int Cantidad = 0;
                    int.TryParse(TCantidad.Text, out Cantidad);

                    int Id_EmpM = 0;
                    if (CCEmpleado.SelectedItem != null)
                    {
                        Id_EmpM = Convert.ToInt32(CCEmpleado.SelectedValue);
                    }

                    mensaje = CNMovimientoInventario.Insertar(Program.vMovimiento_Inventario, Id_ProdM, Cantidad, CTipodemovimiento.Text,
                    Id_EmpM, DFecha.Value);
                }

                MessageBox.Show(mensaje, "Mensage de Inventario Farmacia", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                //Se prepara todo para la próxima operación
                Program.nuevo = false;

                Limpiar(); //Llama al método LimpiaObjetos
            } //Fin del else para validar los datos
        }

    



    private void Bsalir_Click(object sender, EventArgs e)
        {
            //Close();
            Movimiento_Inventario.ActiveForm.Close();
            
        }

      

       

   
      

   

        
      

        private void TRepresentaciongrafica_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el texto del TextBox no está vacío
            if (!string.IsNullOrEmpty(TRepresentaciongrafica.Text))
            {
                // Asignar la imagen del PictureBox usando la dirección de la imagen proporcionada por el TextBox
                pictureBox1.ImageLocation = TRepresentaciongrafica.Text;

                // Asegurarse de que la imagen se ajuste correctamente al tamaño del PictureBox
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                // Deshabilitar el TextBox
                TRepresentaciongrafica.ReadOnly = true;
            }
        }



       

        private void Movimiento_Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir del formulario!\n¿Seguro que desea hacerlo?", "Mensaje de Botica Sila",
                 MessageBoxButtons.YesNo
               , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void Limpiar()
        {

            textBox1.Clear();
            CCEmpleado.Text = null;
            TCantidad.Clear();
            CTipodemovimiento.Text = null;
            DFecha.Value = System.DateTime.Now.Date;
            TNombre.Clear();
            CCategoria.Text = null;
            pictureBox1.Image = null;
            TRepresentaciongrafica.Clear();

        }

        private void Movimiento_Inventario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        public void RecuperaDatos()
        {
            string vparametro = Program.vId_Producto.ToString();
            CNProducto CNProducto = new CNProducto();
            DataTable dt = new DataTable();
            dt = CNProducto.ProductoObtener(vparametro);
            //Recorremos cada fila del DataTable asignando a los controles de edición los valores de 
            //los campos correspondientes
            foreach (DataRow row in dt.Rows)
            {
              
                TNombre.Text = row["Nombre"].ToString();
                CCategoria.Text = ObtenerNombreCategoria(row["Id_Categoria"].ToString());
                TRepresentaciongrafica.Text = row["Representacion_Grafica"].ToString();
           


            }
        } //Fin del metodo RecuperarDatos


    }
}
