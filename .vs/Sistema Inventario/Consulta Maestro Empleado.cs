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
    public partial class Consulta_Maestro_Empleado : Form
    {
        public int vId_Empleado = 0, vtieneparametro = 0, indice = 1;
        public string valorparametro = "", mensaje = "";
        CNEmpleado objempleado = new CNEmpleado();
        CNMovimientoInventario objMovimiento = new CNMovimientoInventario();

        public Consulta_Maestro_Empleado()
        {
            InitializeComponent();
            DGVDatos.SelectionChanged += DGVDatos_SelectionChanged; // Asignar el evento aquí
        }

        private void Consulta_Empleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir del formulario!\n¿Seguro que desea hacerlo?", "Mensaje de Botica Sila",
              MessageBoxButtons.YesNo
            , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void Consulta_Empleado_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            MostrarDatos(); //Método que llena el DataGrid
            MostrarDatos3();
            Tbuscar.Focus(); //El TextBox Buscar recibe el cursor
            DGVDatos.SelectionChanged += DGVDatos_SelectionChanged;
        }



        private void DataGridViewDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            //if (DGVDatos.CurrentRow != null) //Si el DataGridView no está vacío
            //    indice = DGVDatos.CurrentRow.Index; //El valor de índice será la fila actua
            if (DGVDatos.CurrentRow != null)
            {
                string valorparametro = "%" + DGVDatos.CurrentRow.Cells["Id_Empleado"].Value.ToString() + "%";
                string idEmpleado = DGVDatos.CurrentRow.Cells["Id_Empleado"].Value.ToString();
                DataTable dt = objMovimiento.MovimientoInventarioConsultar(idEmpleado);

            }
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

        private void BCancelar_Click(object sender, EventArgs e)
        {
            FREmpleado reporte = new FREmpleado();
            reporte.ShowDialog();
        }

        private void Tbuscar_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVdatos1.CurrentRow != null) //Si el DataGridView no está vacío
                indice = DGVdatos1.CurrentRow.Index; //El valor de índice será la fila
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (DGVdatos1.Rows.Count > 1) //Si no estamos al inicio del DataGridView, vamos al inicio
            {
                indice = 0;
                DGVdatos1.CurrentCell = DGVdatos1.Rows[indice].Cells[DGVdatos1.CurrentCell.ColumnIndex];
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (indice > 0) //Si no estamos al inicio del DataGridView, retrocedemos 1 fila
            {
                indice = indice - 1;
                DGVdatos1.CurrentCell =
                DGVdatos1.Rows[indice].Cells[DGVdatos1.CurrentCell.ColumnIndex];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVdatos1.RowCount - 1) //Si no estamos al final del DataGridView, avanzamos 1 fila
            {
                indice++;
                DGVdatos1.CurrentCell =
               DGVdatos1.Rows[indice].Cells[DGVdatos1.CurrentCell.ColumnIndex];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVdatos1.RowCount - 1) //Si no estamos al final del DataGridView
            {
                indice = DGVdatos1.Rows.Count - 2; //vamos a la última fila del DataGridView
                DGVdatos1.CurrentCell =
               DGVdatos1.Rows[indice].Cells[DGVdatos1.CurrentCell.ColumnIndex];
            }
        }


        //private void MostrarDatos4() //4
        //{

        //   // string valorparametro = tbBuscar.Text.Trim();



        //    DataTable dt = objMovimiento.MovimientoInventarioConsultar(valorparametro);

        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        DGVdatos1.DataSource = dt;
        //        DGVdatos1.Columns[0].Width = 80;
        //        DGVdatos1.Columns[1].Width = 125;
        //        DGVdatos1.Columns[2].Width = 200;
        //        DGVdatos1.Columns[3].Width = 125;
        //        DGVdatos1.Columns[4].Width = 125;


        //    }
        //    else
        //    {
        //        // MessageBox.Show("No se encontraron empleados.");
        //    }
        //    DGVdatos1.Refresh(); //Se refresca el DataGridView
        //                        //   LCantMov.Text = Convert.ToString(DGVdatos.RowCount); //Se muestra la cantidad de datos
        //    if (DGVdatos1.RowCount <= 0) //Si no se obtienen datos de retorno
        //    {
        //        //     MessageBox.Show("Ningún dato que mostrar!"); //Se muestra un mensaje de error
        //    }
        //}


        private void MostrarDatos4(int idEmpleado)
        {
            string valorparametro = Tbuscar.Text.Trim();
            DataTable dt = objMovimiento.MovimientoInventarioConsultar(valorparametro);

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVdatos1.DataSource = dt;
                DGVdatos1.Columns[0].Width = 80;
                DGVdatos1.Columns[1].Width = 125;
                DGVdatos1.Columns[2].Width = 200;
                DGVdatos1.Columns[3].Width = 125;
                DGVdatos1.Columns[4].Width = 125;
               
            }
            else
            {
                // MessageBox.Show("No se encontraron movimientos.");
            }

            DGVdatos1.Refresh();

            if (DGVdatos1.RowCount <= 0)
            {
                // MessageBox.Show("Ningún dato que mostrar.");
            }
        }


        private void MostrarDatos3() //3
        {

           // string valorparametro = tbBuscar.Text.Trim();



            DataTable dt = objMovimiento.MovimientoInventarioConsultarTodos();

            if (dt != null && dt.Rows.Count > 0)
            {
                DGVdatos1.DataSource = dt;
                DGVdatos1.Columns[0].Width = 80;
                DGVdatos1.Columns[1].Width = 125;
                DGVdatos1.Columns[2].Width = 200;
                DGVdatos1.Columns[3].Width = 125;
                DGVdatos1.Columns[4].Width = 125;


            }
            else
            {
                // MessageBox.Show("No se encontraron empleados.");
            }
            DGVdatos1.Refresh(); //Se refresca el DataGridView
            LCantMov1.Text = Convert.ToString(DGVdatos1.RowCount); //Se muestra la cantidad de datos
            if (DGVdatos1.RowCount <= 0) //Si no se obtienen datos de retorno
            {
                //     MessageBox.Show("Ningún dato que mostrar!"); //Se muestra un mensaje de error
            }
        }

        private void DGVDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
            {
                int idEmpleadoSeleccionado = Convert.ToInt32(DGVDatos.CurrentRow.Cells["Id_Empleado"].Value);
                MostrarDatos4(idEmpleadoSeleccionado);
            }
        }

        private void BImprimir_Click(object sender, EventArgs e)
        {
            FRMovimientoInventario reporte = new FRMovimientoInventario();
            reporte.ShowDialog();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            Close(); //Se cierra el formulario
                     //  Categoria.ActiveForm.Close();
        }


        private void MostrarDatos()
        {

            string valorparametro = Tbuscar.Text.Trim();
            CNEmpleado empleado = new CNEmpleado();


            DataTable dt = empleado.EmpleadoObtenerTodos();

            if (empleado.EmpleadoObtenerTodos() != null)
            {
                DGVDatos.DataSource = empleado.EmpleadoObtenerTodos();
                DGVDatos.Columns[0].Width = 80;
                DGVDatos.Columns[1].Width = 200;
                DGVDatos.Columns[2].Width = 225;
                DGVDatos.Columns[3].Width = 100;
                DGVDatos.Columns[4].Width = 125;
                DGVDatos.Columns[5].Width = 125;
                DGVDatos.Columns[6].Width = 150;
                DGVDatos.Columns[7].Width = 125;
                DGVDatos.Columns[8].Width = 150;
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


        private void MostrarDatos2()
        {

            string valorparametro = Tbuscar.Text.Trim();
            CNEmpleado empleado = new CNEmpleado();


            DataTable dt = empleado.EmpleadoObtener(valorparametro);

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
                // MessageBox.Show("No se encontraron empleados.");
            }
        }

    

   
}
}
