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
    public partial class Consulta_Movimiento_Inventario : Form
    {
        public int vId_Movimiento = 0, vtieneparametro = 0, indice = 1;
        public string valorparametro = "", mensaje = "";
        CNMovimientoInventario objMovimiento = new CNMovimientoInventario();


        public Consulta_Movimiento_Inventario()
        {
            InitializeComponent();
        }

        private void PTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Consulta_Movimiento_Inventario_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            MostrarDatos(); //Método que llena el DataGrid
            tbBuscar.Focus(); //El TextBox Buscar recibe el cursor

        }

        private void Consulta_Movimiento_Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir del formulario! \n Seguro que desea hacerlo?",
                                "Mensaje de InventarioMAJO",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

       
        private void DGVdatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVdatos.CurrentRow != null) //Si el DataGridView no está vacío
                indice = DGVdatos.CurrentRow.Index; //El valor de índice será la fila
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            if (tbBuscar.Text != String.Empty) //Si se introdujo un dato en el textbox
            {
                vtieneparametro = 1; //se indica que se trabajará con parámetros
                                     //Se coloca el signo % para que el dato indicado se busque en cualquier parte del campo
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
            }
            else //si el textbox está vacío 
            {
                vtieneparametro = 0; //se indica que no se trabajará con parámetros
                valorparametro = ""; //Se vuelve vacío la variable del parámetro.
            }
            MostrarDatos(); //Se llama al método MostrarDatos
            MostrarDatos2();
            tbBuscar.Focus(); //Se le pasa el cursos al textbox
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            if (DGVdatos.Rows.Count > 1) //Si no estamos al inicio del DataGridView, vamos al inicio
            {
                indice = 0;
                DGVdatos.CurrentCell = DGVdatos.Rows[indice].Cells[DGVdatos.CurrentCell.ColumnIndex];
            }
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0) //Si no estamos al inicio del DataGridView, retrocedemos 1 fila
            {
                indice = indice - 1;
                DGVdatos.CurrentCell =
                DGVdatos.Rows[indice].Cells[DGVdatos.CurrentCell.ColumnIndex];
            }
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVdatos.RowCount - 1) //Si no estamos al final del DataGridView, avanzamos 1 fila
            {
                indice++;
                DGVdatos.CurrentCell =
               DGVdatos.Rows[indice].Cells[DGVdatos.CurrentCell.ColumnIndex];
            }
        }

        private void BUltimo_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVdatos.RowCount - 1) //Si no estamos al final del DataGridView
            {
                indice = DGVdatos.Rows.Count - 2; //vamos a la última fila del DataGridView
                DGVdatos.CurrentCell =
               DGVdatos.Rows[indice].Cells[DGVdatos.CurrentCell.ColumnIndex];
            }
        }

        private void PBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            FRMovimientoInventario reporte = new FRMovimientoInventario();
            reporte.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //if (!string.IsNullOrEmpty(tbBuscar.Text))
            //{
            //    valorparametro = tbBuscar.Text.Trim();
            //    vtieneparametro = 1;
            //    MostrarDatos2();
            //    tbBuscar.Focus();
            //}
            //else
            //{
            //    vtieneparametro = 0;
            //    valorparametro = "";
            //    MostrarDatos();
            //    tbBuscar.Focus();
            //}

            if (tbBuscar.Text != String.Empty) //Si se introdujo un dato en el textbox
            {
                vtieneparametro = 1; //se indica que se trabajará con parámetros
                                     //Se coloca el signo % para que el dato indicado se busque en cualquier parte del campo
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
            }
            else //si el textbox está vacío 
            {
                vtieneparametro = 0; //se indica que no se trabajará con parámetros
                valorparametro = ""; //Se vuelve vacío la variable del parámetro.
            }
            MostrarDatos(); //Se llama al método MostrarDatos
            MostrarDatos2();
            tbBuscar.Focus(); //Se le pasa el cursos al textbox
        }

        

        private void BAceptar_Click(object sender, EventArgs e)
        {
            Categoria.ActiveForm.Close();
        }


        private void MostrarDatos2() //4
        {

          string valorparametro = tbBuscar.Text.Trim();
         


            DataTable dt = objMovimiento.MovimientoInventarioConsultar1(valorparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVdatos.DataSource = dt;
                DGVdatos.Columns[0].Width = 80;
                DGVdatos.Columns[1].Width = 125;
                DGVdatos.Columns[2].Width = 200;
                DGVdatos.Columns[3].Width = 125;
                DGVdatos.Columns[4].Width = 125;
             

            }
            else
            {
                // MessageBox.Show("No se encontraron empleados.");
            }
            DGVdatos.Refresh(); //Se refresca el DataGridView
         //   LCantMov.Text = Convert.ToString(DGVdatos.RowCount); //Se muestra la cantidad de datos
            if (DGVdatos.RowCount <= 0) //Si no se obtienen datos de retorno
            {
                //     MessageBox.Show("Ningún dato que mostrar!"); //Se muestra un mensaje de error
            }
        }

        private void MostrarDatos() //3
        {

            string valorparametro = tbBuscar.Text.Trim();
           


            DataTable dt = objMovimiento.MovimientoInventarioConsultarTodos();

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVdatos.DataSource = dt;
                DGVdatos.Columns[0].Width = 80;
                DGVdatos.Columns[1].Width = 125;
                DGVdatos.Columns[2].Width = 200;
                DGVdatos.Columns[3].Width = 125;
                DGVdatos.Columns[4].Width = 125;


            }
            else
            {
                // MessageBox.Show("No se encontraron empleados.");
            }
            DGVdatos.Refresh(); //Se refresca el DataGridView
            LCantMov.Text = Convert.ToString(DGVdatos.RowCount); //Se muestra la cantidad de datos
            if (DGVdatos.RowCount <= 0) //Si no se obtienen datos de retorno
            {
                //     MessageBox.Show("Ningún dato que mostrar!"); //Se muestra un mensaje de error
            }
        }
    }
}
