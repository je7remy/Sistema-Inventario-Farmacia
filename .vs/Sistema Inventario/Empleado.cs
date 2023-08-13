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
    public partial class Empleado : Form
    {
        public string valorparametro = "", mensaje = "";
       
        public Empleado()
        {
            InitializeComponent();
            Program.nuevo = true;

        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
           // Empleado.ActiveForm.Close();
            this.Close();
            this.LimpiaObjetos();
        }

        //Método propio para limpiar los objetos del formulario. Asegúrese de utilizar el nombre
        // correcto de cada objeto
        public void LimpiaObjetos()
        {
            //Para limpiar TextBox.
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedItem = 0;
            comboBox2.SelectedItem = 0;
            comboBox3.SelectedItem = 0;
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = ""; //Establece el valor por defecto del Combobox
        } //Fin del método LimpiaObjetos


          //Habilita / inhabilita los objetos del formulario segun lo indicado por el parámetro valor
        private void HabilitaControles(bool valor)
        {
            textBox1.ReadOnly = true;
            textBox2.Enabled = valor;//la propiedad ReadOnly hace de solo lectura un objeto
            textBox3.Enabled = valor; //la propiedad Enabled habilita o inhabilita un objeto
            textBox4.Enabled = valor;
            comboBox1.Enabled = valor;
            comboBox2.Enabled = valor;
            comboBox3.Enabled = valor;
            dateTimePicker1.Enabled = valor;
            maskedTextBox1.Enabled = valor;
            maskedTextBox2.Enabled = valor;

          

            if (Program.nuevo)
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
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





        private void Empleado_FormClosing(object sender, FormClosingEventArgs e)
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
            textBox2.Focus(); //Coloca el cursor en el TextBox indicado

        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            ////Validamos los datos requeridos entes de Insertar o Actualizar
            //if (textBox1.Text == String.Empty) //Si el textbox está vacío mostrar un error y ubicar 
            //{ // el cursor en dicho textbox 
            //    MessageBox.Show("Debe rellenar todos los campos!");
            //    textBox1.Focus();
            //}
            //else
            if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                textBox2.Focus();
            }
            else
            if (textBox3.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                textBox3.Focus();
            }
            else
            if (textBox4.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                textBox4.Focus();
            }
            else
            if (comboBox1.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                comboBox1.Focus();
            }
            else
            if (comboBox2.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                comboBox2.Focus();
            }
            else
            if (comboBox3.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                comboBox3.Focus();
            }
            else
            if (maskedTextBox1.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                maskedTextBox1.Focus();
            }
            else
            if (maskedTextBox2.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                maskedTextBox2.Focus();
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

                    mensaje = CNEmpleado.Insertar(Program.vId_Empleado,
                                                  textBox2.Text,
                                                  textBox3.Text,
                                                  textBox4.Text,
                                                  maskedTextBox1.Text,
                                                  //maskedTextBox3.Text ,
                                                  dateTimePicker1.Value,
                                                  maskedTextBox2.Text,
                                                  comboBox2.Text,
                                                  comboBox1.Text,
                                                  comboBox3.Text);
                }
                 else //de lo contrario se Modificarán los datos del registro correspondiente
                {
                    //Se llama al método Insertar de la clase CNSuplidor de la capa de negocio
                    //pasándole como parámetros los valores leídos en los controles del formulario. 
                    // como: textbox, combobox, DateTimePicker, etc.
                    //Los parámetros se pasan en el orden en que se reciben y con el tipo de dato esperado
                    mensaje = CNEmpleado.Actualizar(Program.vId_Empleado,
                                                    textBox2.Text,
                                                    textBox3.Text,
                                                    textBox4.Text,
                                                    maskedTextBox1.Text,
                                                    dateTimePicker1.Value,
                                                    maskedTextBox2.Text,
                                                    comboBox2.Text,
                                                    comboBox1.Text,
                                                    comboBox3.Text);
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
            if (!textBox1.Equals(""))
            {
                Program.modificar = true; //el formulaario se prepara para modificar datos
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Empleado para poder Modificar sus datos!");
            }
        }

        private void Empleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            Busqueda_Empleado busqueda_Empleado = new Busqueda_Empleado();
            busqueda_Empleado.ShowDialog();

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

            } //Fin del método Click del botón Buscar

        private void Empleado_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones(); //Habilita los objetos y botones correspondientes
            LimpiaObjetos(); //Llama al método LimpiaObjetos
        }

        public void RecuperaDatos()
        {
            string vparametro = Program.vId_Empleado.ToString();
            CNEmpleado CNEmpleado = new CNEmpleado();
            DataTable dt = CNEmpleado.EmpleadoObtener(vparametro); //Llenamos el DataTable

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                textBox1.Text = row.Field<int>("Id_Empleado").ToString();
                textBox2.Text = row.Field<string>("Nombre");
                comboBox1.Text = row.Field<string>("Sexo");
                maskedTextBox1.Text = row.Field<string>("Telefono");
                dateTimePicker1.Value = row.Field<DateTime>("Fecha_Nac");
                textBox4.Text = row.Field<string>("Direccion");
                comboBox2.Text = row.Field<string>("Estado");
                textBox3.Text = row.Field<string>("Apellido");
                comboBox3.Text = row.Field<string>("Cargo");
                maskedTextBox2.Text = row.Field<string>("Cedula");
            }
            else
            {
                // No se encontraron datos para el Id_Empleado específico
                // Puedes agregar aquí un mensaje de error o tomar alguna otra acción
            }
        }

    }


}


