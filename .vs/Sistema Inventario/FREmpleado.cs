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
    public partial class FREmpleado : Form
    {
        public FREmpleado()
        {
            InitializeComponent();
        }

        private void FREmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DBInventarioEmpleado.Empleado' Puede moverla o quitarla según sea necesario.
            this.EmpleadoTableAdapter.Fill(this.DBInventarioEmpleado.Empleado);

            this.reportViewer1.RefreshReport();
        }
    }
}
