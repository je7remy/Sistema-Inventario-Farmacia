using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventario
{
    public partial class Fmenu : Form
    {
        
        public Fmenu()
        {
            InitializeComponent();
            
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.ShowDialog();
        }

        private void empleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Empleado consulta_empleado = new Consulta_Empleado();
            consulta_empleado.ShowDialog();
        }

        private void movimientoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimiento_Inventario movimiento_inventario = new Movimiento_Inventario();
            movimiento_inventario.ShowDialog();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Acerca_de acerca_de = new Acerca_de();
            acerca_de.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[1].Text = "Fecha/Hora: " + DateTime.Now.ToString();
        }

        private void Fmenu_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Nombre de usuario o clave incorrecta, "+"Acceso denegado.", "Sistema inventario.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Registro borrado satisfactoriamente!", "Sistema inventario.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.ShowDialog();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Producto consulta_producto = new Consulta_Producto();
            consulta_producto.ShowDialog();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Categoria consulta_categoria = new Consulta_Categoria();
            consulta_categoria.ShowDialog();
        }

        private void movimientoInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Movimiento_Inventario consulta_movimiento_inventario = new Consulta_Movimiento_Inventario();
            consulta_movimiento_inventario.ShowDialog();
        }

        private void contenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Bienvenida bienvenida = new Bienvenida();
            bienvenida.ShowDialog();
        }

        private void registrarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copia_de_seguridad copia_de_seguridad = new Copia_de_seguridad();
            copia_de_seguridad.ShowDialog();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar_copia_de_seguridad guardar_copia_de_seguridad = new Guardar_copia_de_seguridad();
            guardar_copia_de_seguridad.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }

        private void Fmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir del Menu Principal!\n¿Seguro que desea hacerlo?", "Mensaje de Botica Sila",
                MessageBoxButtons.YesNo
              , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void datosGeneralesDelEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FREmpleado reporte = new FREmpleado();
            reporte.ShowDialog();
        }

        private void datosGeneralesDeLosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRProducto reporte = new FRProducto();
            reporte.ShowDialog();
        }

        private void datosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMovimientoInventario reporte = new FRMovimientoInventario();
            reporte.ShowDialog();
        }
    }
    }

