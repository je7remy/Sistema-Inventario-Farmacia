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
    public partial class Consulta_Producto : Form
    {


        public int vId_Producto = 0, vtieneparametro = 0, indice = 1;
        public string valorparametro = "", mensaje = "";
        CNProducto objproducto = new CNProducto();


        public Consulta_Producto()
        {
            InitializeComponent();
        }

        private void Consulta_Producto_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Esto le hara salir del formulario!\n¿Seguro que desea hacerlo?", "Mensaje de Botica Sila",
              MessageBoxButtons.YesNo
            , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void Consulta_Producto_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            MostrarDatos(); //Método que llena el DataGrid
            Tbuscar.Focus(); //El TextBox Buscar recibe el cursor
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

        private void BCancelar_Click(object sender, EventArgs e)
        {
            FRProducto reporte = new FRProducto();
            reporte.ShowDialog();
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
                indice = DGVDatos.Rows.Count - 2; //vamos a la última fila del DataGridView
                DGVDatos.CurrentCell =
               DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }

        }

        private void Tbuscar_TextChanged(object sender, EventArgs e)
        {
           if (Tbuscar.Text != String.Empty) // Si se introdujo un dato en el textbox
{
    vtieneparametro = 1; // se indica que se trabajará con parámetros
    valorparametro = "%" + Tbuscar.Text.Trim() + "%";
}
else // si el textbox está vacío
{
    vtieneparametro = 0; // se indica que no se trabajará con parámetros
    valorparametro = ""; // Se vuelve vacía la variable del parámetro.
}

MostrarDatos(); // Se llama al método MostrarDatos
MostrarDatos2();
Tbuscar.Focus(); // Se pasa el cursor al textbox

        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            Categoria.ActiveForm.Close();
        }


        private void MostrarDatos()
        {
            {
                string valorparametro = Tbuscar.Text.Trim();
                CNProducto CNProducto = new CNProducto();

                // Aquí es donde se llama al método EmpleadoConsultarTodos de la clase CDEmpleado
                DataTable dt = CNProducto.ProductoObtenerTodos();

                if (CNProducto.ProductoObtenerTodos() != null)
                {
                    DGVDatos.DataSource = CNProducto.ProductoObtenerTodos();
                    DGVDatos.Columns[0].Width = 80; //Id_Prod
                    DGVDatos.Columns[1].Width = 200; //Nombre_Prod
                    DGVDatos.Columns[2].Width = 200; //Marca_Prod
                    DGVDatos.Columns[3].Width = 200; //Fecha_Cad
                    DGVDatos.Columns[4].Width = 90; //Estado
                    DGVDatos.Columns[5].Width = 90; //Existencia
                    DGVDatos.Columns[6].Width = 90; //Id_Cat

                }
                else //Si el valor de vtieneparametro es 1 se ejecuta el método que filtra datos según el parámetro
                {
                    MessageBox.Show("No se retornó ningún valor!");
                }
                DGVDatos.Refresh(); //Se refresca el DataGridView
                LCantMov.Text = Convert.ToString(DGVDatos.RowCount-1); //Se muestra la cantidad de datos
                if (DGVDatos.RowCount <= 0) //Si no se obtienen datos de retorno
                {
                    MessageBox.Show("Ningún dato que mostrar!"); //Se muestra un mensaje de error
                }
            }
        }



        private void MostrarDatos2()
        {
            string valorparametro = Tbuscar.Text.Trim();
            CNProducto CNProducto = new CNProducto();

            // Aquí es donde se llama al método EmpleadoConsultarTodos de la clase CDEmpleado
            DataTable dt = CNProducto.ProductoObtener(valorparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVDatos.DataSource = dt;

                if (dt.Columns.Count >= 9)
                {
                    DGVDatos.Columns[0].Width = 80;
                    DGVDatos.Columns[1].Width = 125;
                    DGVDatos.Columns[2].Width = 200;
                    DGVDatos.Columns[3].Width = 125;
                    DGVDatos.Columns[4].Width = 125;
                    DGVDatos.Columns[5].Width = 125;
                    DGVDatos.Columns[6].Width = 100;
                    DGVDatos.Columns[7].Width = 100;
                    DGVDatos.Columns[8].Width = 100;
                    // Puedes continuar configurando más columnas si es necesario.
                }
                else
                {
                    // Si el DataTable no tiene suficientes columnas, muestra un mensaje o realiza alguna acción adecuada.
                    MessageBox.Show("El DataTable no contiene suficientes columnas.");
                }
            }
            else
            {
                // Si el DataTable está vacío, muestra un mensaje o realiza alguna acción adecuada.
                // MessageBox.Show("No se encontraron empleados.");
            }
        }





    }
}