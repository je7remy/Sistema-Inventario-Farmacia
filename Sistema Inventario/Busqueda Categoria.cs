using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Sistema_Inventario
{
    public partial class Busqueda_Categoria : Form
    {

        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";

        public Busqueda_Categoria()
        {
            InitializeComponent();
            //   Program.nuevo = false;
        }

        private void Busqueda_Categoria_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vId_Categoria = 0; //variable global que tomará el valor seleccionado
            MostrarDatos2(); //Llamo al Método que llena el DataGrid
            Tbuscar.Focus(); //El TextBox Buscar recibe el cursor
        }

        private void Busqueda_Categoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir del formulario!\n¿Seguro que desea hacerlo?", "Mensaje de Botica Sila",
                MessageBoxButtons.YesNo
              , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            //Busqueda_Empleado.ActiveForm.Close();
            Program.modificar = false; //variable global a toda la solución 
            Close(); //Se cierra el formulario
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null) //Si el DataGridView no está vacío
                indice = DGVDatos.CurrentRow.Index; //El valor de índice será la fila actual
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null) //Si el DataGridView no está vacío
            {
                //variable global a toda la solución se hace verdadera y se le asigna a la variable global vidSuplidor 
                // el valor de la clave correspondiente
                Program.modificar = true;
                Program.vId_Categoria = Convert.ToInt32(DGVDatos.CurrentRow.Cells[0].Value);
            }
            Close();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 1) //Si no estamos al inicio del DataGridView, vamos al inicio
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }

        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0) //Si no estamos al inicio del DataGridView, retrocedemos 1 fila
            {
                indice = indice - 1;
                DGVDatos.CurrentCell =
                DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1) //Si no estamos al final del DataGridView, avanzamos 1 fila
            {
                indice++;
                DGVDatos.CurrentCell =
               DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }

        }

        private void BUltimo_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1) //Si no estamos al final del DataGridView
            {
                indice = DGVDatos.Rows.Count - 1; //vamos a la última fila del DataGridView
                DGVDatos.CurrentCell =
               DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void DGVDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //si se pulsa en el encabezado, RowIndex será menor que cero y no se hará nada
            if (!(e.RowIndex > -1))
            {
                return;
            }
            BAceptar_Click(sender, e); //Se ejecuta el método del botón Aceptar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Tbuscar.Text != String.Empty) //Si se introdujo un dato en el textbox
            {

                vtieneparametro = 1; //se indica que se trabajará con parámetros
                                     //Se coloca el signo % para que el dato indicado se busque en cualquier parte del campo
                valorparametro = "%" + Tbuscar.Text.Trim() + "%";
                valorparametro = Tbuscar.Text.Trim();
            }
            else //si el textbox está vacío
            {
                vtieneparametro = 0; //se indica que no se trabajará con parámetros
                valorparametro = ""; //Se vuelve vacío la variable del parámetro.
                MostrarDatos2();
            }

            MostrarDatos(); //Se llama al método MostrarDatos


        }


        private void MostrarDatos()
        {
            valorparametro = Tbuscar.Text.Trim();
            CNCategoria categoria = new CNCategoria();

            DataTable dt = categoria.CategoriaConsultar(valorparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVDatos.DataSource = dt;
                DGVDatos.Columns[0].Width = 25;
                DGVDatos.Columns[1].Width = 50;
                DGVDatos.Columns[2].Width = 200;
            }
            else
            {

               
            }

            // Mensajes de depuración
            if (dt == null)
            {
                //   MessageBox.Show("El DataTable es nulo.");
            }
            else
            {
                //   MessageBox.Show("Se encontraron " + dt.Rows.Count + " categorías.");
            }
        }

        private void Tbuscar_TextChanged(object sender, EventArgs e)
        {
            if (Tbuscar.Text != String.Empty) //Si se introdujo un dato en el textbox
            {

                vtieneparametro = 1; //se indica que se trabajará con parámetros
                                     //Se coloca el signo % para que el dato indicado se busque en cualquier parte del campo
                valorparametro = "%" + Tbuscar.Text.Trim() + "%";
                valorparametro = Tbuscar.Text.Trim();
            }
            else //si el textbox está vacío
            {
                vtieneparametro = 0; //se indica que no se trabajará con parámetros
                valorparametro = ""; //Se vuelve vacío la variable del parámetro.
                MostrarDatos2();
            }

            MostrarDatos(); //Se llama al método MostrarDatos
        }

            private void MostrarDatos2()

        {
            valorparametro = Tbuscar.Text.Trim();
            //string valorparametro = Tbuscar.Text.Trim();
            CNCategoria categoria = new CNCategoria();

            //Aquí es donde se llama al método EmpleadoConsultarTodos de la clase CDEmpleado
            DataTable dt = categoria.CategoriaConsultarTodos();

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVDatos.DataSource = dt;
                DGVDatos.Columns[0].Width = 25;
                DGVDatos.Columns[1].Width = 25;
                DGVDatos.Columns[2].Width = 200;


            }
            else
            {
                
                    


            }
        }






    }
}
