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
    public partial class FReporteProducto : Form
    {
        public FReporteProducto()
        {
            InitializeComponent();
        }

        private void FReporteProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DBInventarioDataSet1.Producto' Puede moverla o quitarla según sea necesario.
            this.ProductoTableAdapter.Fill(this.DBInventarioDataSet1.Producto);

            this.reportViewer1.RefreshReport();
        }
    }
}
