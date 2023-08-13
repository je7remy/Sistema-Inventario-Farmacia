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
    public partial class FRMovimientoInventario : Form
    {
        public FRMovimientoInventario()
        {
            InitializeComponent();
        }

        private void FRMovimientoInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DBInventarioMovimiento_Inventario.Movimiento_Inventario' Puede moverla o quitarla según sea necesario.
            this.Movimiento_InventarioTableAdapter.Fill(this.DBInventarioMovimientoInventario.Movimiento_Inventario);


            this.reportViewer1.RefreshReport();
            // this.reportViewer2.RefreshReport();
            // this.reportViewer1.RefreshReport();
        }
    }
}
