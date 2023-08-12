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
    public partial class Consulta_Categoria : Form
    {


        public int vId_Categoria = 0, vtieneparametro = 0, indice = 1;
        public string valorparametro = "", mensaje = "";
        CNCategoria objcategoria = new CNCategoria();


        public Consulta_Categoria()
        {
            InitializeComponent();
        }

        private void Consulta_Categoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir del formulario!\n¿Seguro que desea hacerlo?", "Mensaje de Botica Sila",
               MessageBoxButtons.YesNo
             , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void Consulta_Categoria_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
         //   Program.vId_Categoria = 0; //variable global que tomará el valor seleccionado
            MostrarDatos(); //Llamo al Método que llena el DataGrid
            Tbuscar.Focus(); //El TextBox Buscar recibe el cursor
        }

     

        private void BCancelar_Click(object sender, EventArgs e)
        {
           Busqueda_Empleado.ActiveForm.Close();
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null) //Si el DataGridView no está vacío
                indice = DGVDatos.CurrentRow.Index; //El valor de índice será la fila actual

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
            }
            MostrarDatos(); //Se llama al método MostrarDatos
            MostrarDatos2();
            Tbuscar.Focus(); //Se le pasa el cursos al textbox

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

        private void BAceptar_Click(object sender, EventArgs e)
        {
            Categoria.ActiveForm.Close();
        }



        private void MostrarDatos()
        {
            CNCategoria objcategoria = new CNCategoria();

            DataTable dt = objcategoria.CategoriaConsultarTodos();

            if (objcategoria.CategoriaConsultarTodos() != null)
            {
                DGVDatos.DataSource = objcategoria.CategoriaConsultarTodos();
                DGVDatos.Columns[0].Width = 25;
                DGVDatos.Columns[1].Width = 25;
                DGVDatos.Columns[2].Width = 200;

            }
            else //Si el valor de vtieneparametro es 1 se ejecuta el método que filtra datos según el parámetro
            {
                MessageBox.Show("No se retornó ningún valor!");
            }
            DGVDatos.Refresh(); //Se refresca el DataGridView
            LCantMov.Text = Convert.ToString(DGVDatos.RowCount); //Se muestra la cantidad de datos
            if (DGVDatos.RowCount <= 0) //Si no se obtienen datos de retorno
            {
                MessageBox.Show("Ningún dato que mostrar!"); //Se muestra un mensaje de error
            }
        } //Fin del método mostrar



        private void MostrarDatos2()
        {
            CNCategoria objcategoria = new CNCategoria();

            DataTable dt = objcategoria.CategoriaConsultar(valorparametro);

         

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVDatos.DataSource = dt;
                DGVDatos.Columns[0].Width = 25;
                DGVDatos.Columns[1].Width = 50;
                DGVDatos.Columns[2].Width = 200;
            }
            else
            {
                //MessageBox.Show("No se encontraron categorias.");
            }
            // DGVDatos.Refresh(); //Se refresca el DataGridView
            ////  LCantMov.Text = Convert.ToString(DGVDatos.RowCount); //Se muestra la cantidad de datos
            //  if (DGVDatos.RowCount <= 0) //Si no se obtienen datos de retorno
            //  {
            //      MessageBox.Show("Ningún dato que mostrar!"); //Se muestra un mensaje de error
            //  }
        } //Fin del método mostrar
    

}
}
