using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//para poder utilizar las instrucciones de SQL
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
//Para acceder a la capa de negocio
using CapaNegocio;

namespace Sistema_Inventario
{
    public partial class Categoria : Form
    {

        public string valorparametro = "", mensaje = "";

        public Categoria()
        {
            InitializeComponent();
            //Program.nuevo = true;
        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            //Categoria.ActiveForm.Close();
            this.Close();
        }

        //Método propio para limpiar los objetos del formulario. Asegúrese de utilizar el nombre
        // correcto de cada objeto
        public void LimpiaObjetos()
        {
            //Para limpiar TextBox.
            TId_Categoria.Clear();
            CNombre_Categoria.SelectedItem = 0;
            TDescripcion.Clear();
          
         
        } //Fin del método LimpiaObjetos


        //Habilita / inhabilita los objetos del formulario segun lo indicado por el parámetro valor
        private void HabilitaControles(bool valor)
        {
            TId_Categoria.ReadOnly = true;
            TDescripcion.Enabled = valor;//la propiedad ReadOnly hace de solo lectura un objeto
            CNombre_Categoria.Enabled = valor;
            if (Program.nuevo)
                CNombre_Categoria.SelectedIndex = 0;
        } //Fin del método HabilitaControles


        //Habilita los botones según el valor que tengan las variables globales nuevo y modificar
        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitaControles(true); //Llamada al método para habilitar los objetos
                Bnuevo.Enabled = false;
                Bguardar.Enabled = true;
                Beditar.Enabled = false;
                Bbuscar.Enabled = false;
                Bcancelar.Enabled = true;
            }
            else
            {
                HabilitaControles(false); //Llamada al método para inhabilitar los objetos
                Bnuevo.Enabled = true;
                Bguardar.Enabled = false;
                Beditar.Enabled = false;
                Bbuscar.Enabled = true;
                Bcancelar.Enabled = false;
            }
        }


        private void Categoria_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones(); //Habilita los objetos y botones correspondientes
            LimpiaObjetos(); //Llama al método LimpiaObjetos
        }

        private void Categoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir del formulario!\n¿Seguro que desea hacerlo?", "Mensaje de Botica Sila",
                MessageBoxButtons.YesNo
              , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void Bnuevo_Click(object sender, EventArgs e)
        {
            LimpiaObjetos(); //LLama al método LimpiaObjetos para prepararlos para la nueva entrada
            Program.nuevo = true; //Se especifica que se agregará un nuevo registro
            Program.modificar = false;
            HabilitaBotones(); //Se habilitan solo aquellos botones que sean necesarios
            CNombre_Categoria.Focus(); //Coloca el cursor en el TextBox indicado
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {


            //Validamos los datos requeridos entes de Insertar o Actualizar
            //if (TId_Categoria.Text == String.Empty) //Si el textbox está vacío mostrar un error y ubicar 
            //{ // el cursor en dicho textbox 
            //    MessageBox.Show("Debe rellenar todos los campos!");
            //    TId_Categoria.Focus();
            //}
            //else
            if (CNombre_Categoria.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                CNombre_Categoria.Focus();
            }
            else
            if (TDescripcion.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                TDescripcion.Focus();
            }

            else
            {
                //Si todo es correcto procede a Insertar o actualizar según corresponda, usaremos las 
                //variables globales a toda la solución contenidas en Program.CS
                if (Program.nuevo) //Si la variable nuevo llega con valor true se van a Insertar nuevos datos
                {
                    //Se llama al método Insertar de la clase CNSuplidor de la capa de negocio
                    //pasándole como parámetros los valores leídos en los controles del formulario. como: 
                    //textbox, combobox, DateTimePicker, etc.
                    //Los parámetros se pasan en el orden en que se reciben y con el tipo de dato esperado

                    mensaje = CNCategoria.Insertar(Program.vId_Categoria,
                                                  CNombre_Categoria.Text,
                                                  TDescripcion.Text
                                                  );
                }
                else //de lo contrario se Modificarán los datos del registro correspondiente
                {
                    //Se llama al método Insertar de la clase CNSuplidor de la capa de negocio
                    //pasándole como parámetros los valores leídos en los controles del formulario. 
                    // como: textbox, combobox, DateTimePicker, etc.
                    //Los parámetros se pasan en el orden en que se reciben y con el tipo de dato esperado
                    mensaje = CNCategoria.Actualizar(Program.vId_Categoria,
                                                  CNombre_Categoria.Text,
                                                  TDescripcion.Text
                                                  );
                }
                //Se muestra el mensaje devuelto por la capa de negocio respecto al resultado de la operación 
                MessageBox.Show(mensaje, "Mensage de Botica Sila", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                //Se prepara todo para la próxima operación
                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones(); //Habilita los objetos y botones correspondientes
                LimpiaObjetos(); //Llama al método LimpiaObjetos
            } //Fin del else para validar los datos
              //            j) Hacer doble clic en un lugar vacío del formulario para generar el evento Load del mismo.
              //Este se ejecuta cuando se habilita el formulario. Escribir dentro el siguiente código:
            Program.nuevo = false; //Valores de las variables globales nuevo y modificar
            Program.modificar = false;

            HabilitaBotones(); //Se habilitarán los objetos y los botones necesarios.
        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {

            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones(); //Habilita los objetos y botones correspondientes
            LimpiaObjetos(); //Llama al método LimpiaObjetos
        }

        private void Beditar_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un Suplidor no se puede modificar
            if (!TId_Categoria.Equals(""))
            {
                Program.modificar = true; //el formulaario se prepara para modificar datos
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Empleado para poder Modificar sus datos!");
            }
        }

        private void Categoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
           
            Busqueda_Categoria busqueda_Categoria = new Busqueda_Categoria();
            busqueda_Categoria.ShowDialog();

            //Llamada al formulario para buscar los datos de la tabla correspondiente. Lo pondremos 
            //en comentario hasta que creemos dicho formulario.
            //FBuscarDepartamento fBuscarDepto = new FBuscarDepartamento();
            //fBuscarDepto.ShowDialog();
            if (Program.modificar)
            {
                RecuperaDatos(); //Llamo al método para recuperar el Depto seleccionado
                Beditar_Click(sender, e); //Llamo al método editar
            }
            else

            {
                LimpiaObjetos(); //Llama al método LimpiaObjetos
                Bbuscar.Focus();
            }
        }

        internal static object AsEnumerable()
        {
            throw new NotImplementedException();
        }

        private void Categoria_Activated(object sender, EventArgs e)
        {
            //Program.nuevo = true;
        }

        public void RecuperaDatos()
        {
            string vparametro = Program.vId_Categoria.ToString();
            CNCategoria CNCategoria = new CNCategoria();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = CNCategoria.CategoriaConsultar(vparametro); //Llenamos el DataTable
                                                              //Recorremos cada fila del DataTable asignando a los controles de edición los valores de 
                                                              //los campos correspondientes

            foreach (DataRow row in dt.Rows)
            {
                TId_Categoria.Text = row["Id_Categoria"].ToString();
                CNombre_Categoria.Text = row["Nombre"].ToString();
                TDescripcion.Text = row["Descripcion"].ToString();
                
            }
        } //Fin del metodo RecuperarDatos

    }
}
