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
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
          Acerca_de.ActiveForm.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Bienvenida.ActiveForm.Close();
        }
    }
}
