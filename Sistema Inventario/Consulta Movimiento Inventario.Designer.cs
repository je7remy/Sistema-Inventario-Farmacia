
namespace Sistema_Inventario
{
    partial class Consulta_Movimiento_Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PTitulo = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.PInformacion = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LInformacion = new System.Windows.Forms.Label();
            this.PBotones = new System.Windows.Forms.Panel();
            this.LCantidad = new System.Windows.Forms.Label();
            this.BAceptar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BUltimo = new System.Windows.Forms.Button();
            this.BSiguiente = new System.Windows.Forms.Button();
            this.BAnterior = new System.Windows.Forms.Button();
            this.BPrimero = new System.Windows.Forms.Button();
            this.DataGridViewDatos = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PTitulo.SuspendLayout();
            this.PInformacion.SuspendLayout();
            this.PBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // PTitulo
            // 
            this.PTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.PTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PTitulo.Controls.Add(this.LTitulo);
            this.PTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PTitulo.Location = new System.Drawing.Point(0, 0);
            this.PTitulo.Name = "PTitulo";
            this.PTitulo.Size = new System.Drawing.Size(1077, 100);
            this.PTitulo.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.White;
            this.LTitulo.Location = new System.Drawing.Point(10, 28);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(634, 36);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Consulta General De Movimiento Inventario.";
            // 
            // PInformacion
            // 
            this.PInformacion.BackColor = System.Drawing.Color.White;
            this.PInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PInformacion.Controls.Add(this.button2);
            this.PInformacion.Controls.Add(this.label1);
            this.PInformacion.Controls.Add(this.textBox1);
            this.PInformacion.Controls.Add(this.LInformacion);
            this.PInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PInformacion.Location = new System.Drawing.Point(0, 100);
            this.PInformacion.Name = "PInformacion";
            this.PInformacion.Size = new System.Drawing.Size(1077, 100);
            this.PInformacion.TabIndex = 1;
            this.PInformacion.Paint += new System.Windows.Forms.PaintEventHandler(this.PTitulo_Paint);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "";
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Image = global::Sistema_Inventario.Properties.Resources._007_lupa;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(715, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 67);
            this.button2.TabIndex = 13;
            this.button2.Tag = "";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button2, "Buscar dato");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(801, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar Dato";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(250, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 32);
            this.textBox1.TabIndex = 1;
            // 
            // LInformacion
            // 
            this.LInformacion.AutoSize = true;
            this.LInformacion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInformacion.Location = new System.Drawing.Point(12, 43);
            this.LInformacion.Name = "LInformacion";
            this.LInformacion.Size = new System.Drawing.Size(206, 22);
            this.LInformacion.TabIndex = 0;
            this.LInformacion.Text = "Ingrese el dato a buscar";
            // 
            // PBotones
            // 
            this.PBotones.BackColor = System.Drawing.Color.SteelBlue;
            this.PBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBotones.Controls.Add(this.LCantidad);
            this.PBotones.Controls.Add(this.BAceptar);
            this.PBotones.Controls.Add(this.BCancelar);
            this.PBotones.Controls.Add(this.BUltimo);
            this.PBotones.Controls.Add(this.BSiguiente);
            this.PBotones.Controls.Add(this.BAnterior);
            this.PBotones.Controls.Add(this.BPrimero);
            this.PBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBotones.Location = new System.Drawing.Point(0, 464);
            this.PBotones.Name = "PBotones";
            this.PBotones.Size = new System.Drawing.Size(1077, 152);
            this.PBotones.TabIndex = 1;
            this.PBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.PBotones_Paint);
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidad.Location = new System.Drawing.Point(221, 5);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(612, 40);
            this.LCantidad.TabIndex = 3;
            this.LCantidad.Text = "Cantidad de Movimiento Inventario:   0";
            // 
            // BAceptar
            // 
            this.BAceptar.AccessibleDescription = "";
            this.BAceptar.BackColor = System.Drawing.SystemColors.Window;
            this.BAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAceptar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.BAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.BAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.BAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAceptar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAceptar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BAceptar.Image = global::Sistema_Inventario.Properties.Resources.salida;
            this.BAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAceptar.Location = new System.Drawing.Point(895, 55);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(143, 67);
            this.BAceptar.TabIndex = 12;
            this.BAceptar.Tag = "";
            this.BAceptar.Text = "&Salir";
            this.BAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BAceptar, "Salir del formulario");
            this.BAceptar.UseVisualStyleBackColor = false;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.AccessibleDescription = "";
            this.BCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.BCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.BCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.BCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BCancelar.Image = global::Sistema_Inventario.Properties.Resources.imprimir;
            this.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelar.Location = new System.Drawing.Point(715, 55);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(163, 67);
            this.BCancelar.TabIndex = 11;
            this.BCancelar.Tag = "";
            this.BCancelar.Text = "&Imprimir";
            this.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BCancelar, "Generar reporte correspondiente");
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BUltimo
            // 
            this.BUltimo.AccessibleDescription = "";
            this.BUltimo.BackColor = System.Drawing.SystemColors.Window;
            this.BUltimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUltimo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.BUltimo.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.BUltimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.BUltimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUltimo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUltimo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BUltimo.Image = global::Sistema_Inventario.Properties.Resources._002_proximo;
            this.BUltimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUltimo.Location = new System.Drawing.Point(555, 55);
            this.BUltimo.Name = "BUltimo";
            this.BUltimo.Size = new System.Drawing.Size(143, 67);
            this.BUltimo.TabIndex = 10;
            this.BUltimo.Tag = "";
            this.BUltimo.Text = "&Ultimo";
            this.BUltimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BUltimo, "Ir al ultimo registro");
            this.BUltimo.UseVisualStyleBackColor = false;
            // 
            // BSiguiente
            // 
            this.BSiguiente.AccessibleDescription = "";
            this.BSiguiente.BackColor = System.Drawing.SystemColors.Window;
            this.BSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.BSiguiente.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.BSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.BSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSiguiente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSiguiente.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BSiguiente.Image = global::Sistema_Inventario.Properties.Resources._003_chevron_derecho;
            this.BSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSiguiente.Location = new System.Drawing.Point(384, 55);
            this.BSiguiente.Name = "BSiguiente";
            this.BSiguiente.Size = new System.Drawing.Size(153, 67);
            this.BSiguiente.TabIndex = 9;
            this.BSiguiente.Tag = "";
            this.BSiguiente.Text = "&Siguiente";
            this.BSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BSiguiente, "Ir al registro siguiente");
            this.BSiguiente.UseVisualStyleBackColor = false;
            // 
            // BAnterior
            // 
            this.BAnterior.AccessibleDescription = "";
            this.BAnterior.BackColor = System.Drawing.SystemColors.Window;
            this.BAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAnterior.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.BAnterior.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.BAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.BAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnterior.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAnterior.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BAnterior.Image = global::Sistema_Inventario.Properties.Resources._004_chevron_izquierdo;
            this.BAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAnterior.Location = new System.Drawing.Point(213, 55);
            this.BAnterior.Name = "BAnterior";
            this.BAnterior.Size = new System.Drawing.Size(154, 67);
            this.BAnterior.TabIndex = 8;
            this.BAnterior.Tag = "";
            this.BAnterior.Text = "&Anterior";
            this.BAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BAnterior, "Ir al registro anterior");
            this.BAnterior.UseVisualStyleBackColor = false;
            // 
            // BPrimero
            // 
            this.BPrimero.AccessibleDescription = "";
            this.BPrimero.BackColor = System.Drawing.SystemColors.Window;
            this.BPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BPrimero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BPrimero.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.BPrimero.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.BPrimero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.BPrimero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPrimero.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPrimero.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BPrimero.Image = global::Sistema_Inventario.Properties.Resources._001_atras;
            this.BPrimero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BPrimero.Location = new System.Drawing.Point(33, 55);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(157, 67);
            this.BPrimero.TabIndex = 7;
            this.BPrimero.Tag = "";
            this.BPrimero.Text = "&Primero";
            this.BPrimero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BPrimero, "Ir al primer registro");
            this.BPrimero.UseVisualStyleBackColor = false;
            // 
            // DataGridViewDatos
            // 
            this.DataGridViewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewDatos.Location = new System.Drawing.Point(0, 200);
            this.DataGridViewDatos.Name = "DataGridViewDatos";
            this.DataGridViewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDatos.Size = new System.Drawing.Size(1077, 264);
            this.DataGridViewDatos.TabIndex = 2;
            // 
            // Consulta_Movimiento_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 616);
            this.Controls.Add(this.DataGridViewDatos);
            this.Controls.Add(this.PInformacion);
            this.Controls.Add(this.PBotones);
            this.Controls.Add(this.PTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Consulta_Movimiento_Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busqueda_Empleado";
            this.PTitulo.ResumeLayout(false);
            this.PTitulo.PerformLayout();
            this.PInformacion.ResumeLayout(false);
            this.PInformacion.PerformLayout();
            this.PBotones.ResumeLayout(false);
            this.PBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PTitulo;
        private System.Windows.Forms.Panel PInformacion;
        private System.Windows.Forms.Panel PBotones;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.DataGridView DataGridViewDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LInformacion;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BUltimo;
        private System.Windows.Forms.Button BSiguiente;
        private System.Windows.Forms.Button BAnterior;
        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LCantidad;
    }
}