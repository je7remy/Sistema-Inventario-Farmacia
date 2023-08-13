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
    public partial class FReporteEmpleado : Form
    {
        public FReporteEmpleado()
        {
            InitializeComponent();
        }

        private void FReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DBInventarioDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.EmpleadoTableAdapter.Fill(this.DBInventarioDataSet.Empleado);

            this.reportViewer1.RefreshReport();
        }
    }
}
