using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//para poder utilizar las instrucciones de SQL
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
//Para acceder a la capa de negocio
using CapaNegocio;

namespace Sistema_Inventario
{
    public partial class Producto : Form
    {
        public string valorparametro = "", mensaje = "";

        public Producto()
        {

            InitializeComponent();
        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            //Producto.ActiveForm.Close();
            this.Close();
        }

     



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = abririmagen.FileName;
                TRepresentaciongrafica.Text = abririmagen.FileName;
                TRepresentaciongrafica.ReadOnly = true;

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

      

        private void Producto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir del formulario!\n¿Seguro que desea hacerlo?", "Mensaje de Botica Sila",
                 MessageBoxButtons.YesNo
               , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            Busqueda_Producto busqueda_Producto = new Busqueda_Producto();
            busqueda_Producto.ShowDialog();
            //Llamada al formulario para buscar los datos de la tabla correspondiente. Lo pondremos 
            //en comentario hasta que creemos dicho formulario.
            //FBuscarDepartamento fBuscarDepto = new FBuscarDepartamento();
            //fBuscarDepto.ShowDialog();
            if (Program.modificar)
            {
                RecuperaDatos(); //Llamo al método para recuperar el Depto seleccionado
                Beditar_Click(sender, e); //Llamo al método editar
            }
            else

            {
                LimpiaObjetos(); //Llama al método LimpiaObjetos
                Bbuscar.Focus();
            }

        }


        public void RecuperaDatos()
        {
            string vparametro = Program.vId_Producto.ToString();
            CNProducto CNProducto = new CNProducto();
            DataTable dt = new DataTable();
            dt = CNProducto.ProductoObtener(vparametro);

            foreach (DataRow row in dt.Rows)
            {
                TId_producto.Text = row["Id_Producto"].ToString();
                TNombre.Text = row["Nombre"].ToString();
                CEstado.Text = row["Estado"].ToString();
                TMarca.Text = row["Marca"].ToString();
                TRepresentaciongrafica.Text = row["Representacion_Grafica"].ToString();
                DFecha_vencimiento.Text = row["Fecha_De_Vencimiento"].ToString();
                TExistencia.Text = row["Existencia"].ToString();

                // Aquí obtenemos el nombre de la categoría en lugar del ID
                CId_Categoria.Text = ObtenerNombreCategoria(row["Id_Categoria"].ToString());

                TPrecio_venta.Text = row["Precio_De_Venta"].ToString();
            }
        }

        private string ObtenerNombreCategoria(string idCategoria)
        {
            CNCategoria cncategoria = new CNCategoria();
            DataTable dt = cncategoria.CategoriaConsultar(idCategoria);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Nombre"].ToString();
            }

            return string.Empty;
        }





        //Método propio para limpiar los objetos del formulario. Asegúrese de utilizar el nombre
        // correcto de cada objeto
        public void LimpiaObjetos()
        {
            //Para limpiar TextBox.
            TId_producto.Clear();
            TNombre.Clear();
            TMarca.Clear();
            DFecha_vencimiento.CustomFormat = "dd/MM/yyyy";
            DFecha_vencimiento.Format = DateTimePickerFormat.Custom;

            if (DFecha_vencimiento.Value == DateTime.MinValue)
            {
                DFecha_vencimiento.Text = "01/01/1750";
            }
            TExistencia.Clear();
            CId_Categoria.SelectedItem = 0;
            CEstado.SelectedItem = 0;
            pictureBox1.Image = null;
            TPrecio_venta.Clear();
            TRepresentaciongrafica.Clear();


        } //Fin del método LimpiaObjetos


       

        //Habilita / inhabilita los objetos del formulario segun lo indicado por el parámetro valor
        private void HabilitaControles(bool valor)
        {
            TId_producto.ReadOnly = true;
            TNombre.Enabled = valor;//la propiedad ReadOnly hace de solo lectura un objeto
            TMarca.Enabled = valor; //la propiedad Enabled habilita o inhabilita un objeto
            TExistencia.Enabled = valor;
            //DFecha_vencimiento.Valor;
            CId_Categoria.Enabled = valor;
            CEstado.Enabled = valor;
            pictureBox1.Enabled = valor;
            TRepresentaciongrafica.Enabled = valor;
            button1.Enabled = valor;
            DFecha_vencimiento.Enabled = valor;
            TPrecio_venta.Enabled = valor;

            if (Program.nuevo)
            CId_Categoria.SelectedItem = 0;
            CEstado.SelectedIndex = 0;
          
        } //Fin del método HabilitaControles

        private void Bnuevo_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            TNombre.Focus();
            HabilitaControles(true);

           

        }


        private void Bguardar_Click(object sender, EventArgs e)
        {
            // Validamos los datos requeridos antes de Insertar o Actualizar
            if (string.IsNullOrEmpty(TNombre.Text) ||
                string.IsNullOrEmpty(TMarca.Text) ||
                string.IsNullOrEmpty(TExistencia.Text) ||
                CId_Categoria.SelectedItem == null ||
                string.IsNullOrEmpty(CEstado.Text) ||
                string.IsNullOrEmpty(TRepresentaciongrafica.Text) ||
                string.IsNullOrEmpty(TPrecio_venta.Text))
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                return;
            }

            int categoriaId;

            if (CId_Categoria.SelectedItem != null && CId_Categoria.SelectedItem is DataRowView)
            {
                DataRowView selectedRow = CId_Categoria.SelectedItem as DataRowView;
                if (selectedRow.Row["Id_Categoria"] != null && int.TryParse(selectedRow.Row["Id_Categoria"].ToString(), out categoriaId))
                {
                    int existenciaInt, precioventaInt;

                    if (!int.TryParse(TExistencia.Text, out existenciaInt) ||
                        !int.TryParse(TPrecio_venta.Text, out precioventaInt))
                    {
                        MessageBox.Show("Existencia y Precio de Venta deben ser valores numéricos válidos.");
                        return;
                    }

                    if (Program.nuevo)
                    {
                        mensaje = CNProducto.Insertar(Program.vId_Producto,
                                                      TNombre.Text,
                                                      categoriaId,
                                                      CEstado.Text,
                                                      TMarca.Text,
                                                      DFecha_vencimiento.Value,
                                                      TRepresentaciongrafica.Text,
                                                      existenciaInt,
                                                      precioventaInt);
                    }
                    else if (Program.modificar)
                    {
                        mensaje = CNProducto.Actualizar(Program.vId_Producto,
                                                        TNombre.Text,
                                                        categoriaId,
                                                        CEstado.Text,
                                                        TMarca.Text,
                                                        DFecha_vencimiento.Value,
                                                        TRepresentaciongrafica.Text,
                                                        existenciaInt,
                                                        precioventaInt);
                    }
                }
                else
                {
                    MessageBox.Show("Categoría no válida.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoría válida.");
                return;
            }

            // Muestra el mensaje devuelto por la capa de negocio respecto al resultado de la operación
            MessageBox.Show(mensaje, "Mensaje de Botica Sila", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Preparar todo para la próxima operación
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
            LimpiaObjetos();
        }


        private void Bcancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones(); //Habilita los objetos y botones correspondientes
            LimpiaObjetos(); //Llama al método LimpiaObjetos
        }

        private void Beditar_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un Suplidor no se puede modificar
            if (!TId_producto.Equals(""))
            {
                Program.modificar = true; //el formulaario se prepara para modificar datos
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un producto para poder Modificar sus datos!");
            }
        }

        private void Producto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            TRepresentaciongrafica.TextChanged += TRepresentaciongrafica_TextChanged;
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
            LimpiaObjetos();

            CNCategoria cncategoria = new CNCategoria();
            DataTable dtCategorias = cncategoria.CategoriaConsultarTodos();

            if (dtCategorias.Rows.Count > 0)
            {
                CId_Categoria.DataSource = dtCategorias;
                CId_Categoria.DisplayMember = "Nombre"; // Cambia esto al nombre de la columna de nombre de categoría
                CId_Categoria.ValueMember = "Id_Categoria"; // Cambia esto al nombre de la columna de ID de categoría
            }
            else
            {
                MessageBox.Show("No se encontraron categorías en la base de datos.");
            }
        }


        private void Producto_Activated(object sender, EventArgs e)
        {
            //Program.nuevo = true;
         

        }

        private void TRepresentaciongrafica_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el texto del TextBox no está vacío
            if (!string.IsNullOrEmpty(TRepresentaciongrafica.Text))
            {
                // Asignar la imagen del PictureBox usando la dirección de la imagen proporcionada por el TextBox
                pictureBox1.ImageLocation = TRepresentaciongrafica.Text;

                // Asegurarse de que la imagen se ajuste correctamente al tamaño del PictureBox
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                // Deshabilitar el TextBox
                TRepresentaciongrafica.ReadOnly = true;
            }
        }



        //Habilita los botones según el valor que tengan las variables globales nuevo y modificar
        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitaControles(true); //Llamada al método para habilitar los objetos
                Bnuevo.Enabled = false;
                Bguardar.Enabled = true;
                Beditar.Enabled = false;
                Bbuscar.Enabled = false;
                Bcancelar.Enabled = true;
            }
            else
            {
                HabilitaControles(false); //Llamada al método para inhabilitar los objetos
                Bnuevo.Enabled = true;
                Bguardar.Enabled = false;
                Beditar.Enabled = false;
                Bbuscar.Enabled = true;
                Bcancelar.Enabled = false;
            }
        }


    }

}