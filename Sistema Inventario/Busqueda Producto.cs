using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using CapaNegocio;

namespace Sistema_Inventario
{
    public partial class Busqueda_Producto : Form
    {


        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";


        public Busqueda_Producto()
        {
            InitializeComponent();
            Program.nuevo = false;

        }

        private void Busqueda_Producto_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vId_Producto = 0; //variable global que tomará el valor seleccionado
            MostrarDatos(); //Llamo al Método que llena el DataGrid
            Tbuscar.Focus(); //El TextBox Buscar recibe el cursor
        }

        private void Busqueda_Producto_FormClosing(object sender, FormClosingEventArgs e)
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
                Program.vId_Producto = Convert.ToInt32(DGVDatos.CurrentRow.Cells[0].Value); //datagridview
                                                                                            // Program.vtextBox1 = Convert.ToInt32(DGVDatos.CurrentRow.Cells[1].Value); //btn buscar
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

        private void BAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0) //Si no estamos al inicio del DataGridView, retrocedemos 1 fila
            {

                indice = indice - 1;
                DGVDatos.CurrentCell =
                DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void DGVDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (int.TryParse(DGVDatos.Rows[e.RowIndex].Cells["Id_Producto"].Value.ToString(), out int valor))
                {
                    Program.modificar = true;
                    Program.vId_Producto = valor;
                }
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Tbuscar.Text != String.Empty) //Si se introdujo un dato en el textbox
            {

                vtieneparametro = 1; //se indica que se trabajará con parámetros
                                     //Se coloca el signo % para que el dato indicado se busque en cualquier parte del campo
                valorparametro = "%" + Tbuscar.Text.Trim() + "%";
                //valorparametro = tbBuscar.Text.Trim();
                MostrarDatos2();
            }
            else //si el textbox está vacío
            {
                vtieneparametro = 0; //se indica que no se trabajará con parámetros
                valorparametro = ""; //Se vuelve vacío la variable del parámetro.
                MostrarDatos();
            }
            //  MostrarDatos(); //Se llama al método MostrarDatos



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

        private void Tbuscar_TextChanged(object sender, EventArgs e)
        {
            if (Tbuscar.Text != String.Empty) //Si se introdujo un dato en el textbox
            {

                vtieneparametro = 1; //se indica que se trabajará con parámetros
                                     //Se coloca el signo % para que el dato indicado se busque en cualquier parte del campo
                valorparametro = "%" + Tbuscar.Text.Trim() + "%";
                //valorparametro = tbBuscar.Text.Trim();
                MostrarDatos2();
            }
            else //si el textbox está vacío
            {
                vtieneparametro = 0; //se indica que no se trabajará con parámetros
                valorparametro = ""; //Se vuelve vacío la variable del parámetro.
                MostrarDatos();
            }
            //  MostrarDatos(); //Se llama al método MostrarDatos



        }
    

    private void MostrarDatos()
        {

            string valorparametro = Tbuscar.Text.Trim();
            CNProducto CNProducto = new CNProducto();

            
            DataTable dt = CNProducto.ProductoObtenerTodos();

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVDatos.DataSource = dt;
                DGVDatos.Columns[0].Width = 80;
                DGVDatos.Columns[1].Width = 125;
                DGVDatos.Columns[2].Width = 200;
                DGVDatos.Columns[3].Width = 125;
                DGVDatos.Columns[4].Width = 125;
                DGVDatos.Columns[5].Width = 125;
                DGVDatos.Columns[6].Width = 100;
                DGVDatos.Columns[7].Width = 100;
                DGVDatos.Columns[8].Width = 90;

            }
            else
            {
                MessageBox.Show("No se encontraron empleados.");
            }
        }











    }

}
