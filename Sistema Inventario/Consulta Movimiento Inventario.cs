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
    public partial class Consulta_Movimiento_Inventario : Form
    {
        public Consulta_Movimiento_Inventario()
        {
            InitializeComponent();
        }

        private void PTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            FRMovimientoInventario reporte = new FRMovimientoInventario();
            reporte.ShowDialog();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            Categoria.ActiveForm.Close();
        }
    }
}
