
namespace Sistema_Inventario
{
    partial class Producto
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
            this.Ptitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Pbotones = new System.Windows.Forms.Panel();
            this.Bnuevo = new System.Windows.Forms.Button();
            this.Bsalir = new System.Windows.Forms.Button();
            this.Bbuscar = new System.Windows.Forms.Button();
            this.Bcancelar = new System.Windows.Forms.Button();
            this.Beditar = new System.Windows.Forms.Button();
            this.Bguardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TId_producto = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TMarca = new System.Windows.Forms.TextBox();
            this.CEstado = new System.Windows.Forms.ComboBox();
            this.DFecha_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.tooltipProducto = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TExistencia = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TPrecio_venta = new System.Windows.Forms.TextBox();
            this.TRepresentaciongrafica = new System.Windows.Forms.TextBox();
            this.CId_Categoria = new System.Windows.Forms.ComboBox();
            this.Ptitulo.SuspendLayout();
            this.Pbotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ptitulo
            // 
            this.Ptitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.Ptitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ptitulo.Controls.Add(this.label1);
            this.Ptitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ptitulo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ptitulo.ForeColor = System.Drawing.Color.White;
            this.Ptitulo.Location = new System.Drawing.Point(0, 0);
            this.Ptitulo.Name = "Ptitulo";
            this.Ptitulo.Size = new System.Drawing.Size(1081, 100);
            this.Ptitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento Producto\r\n";
            // 
            // Pbotones
            // 
            this.Pbotones.BackColor = System.Drawing.Color.SteelBlue;
            this.Pbotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pbotones.Controls.Add(this.Bnuevo);
            this.Pbotones.Controls.Add(this.Bsalir);
            this.Pbotones.Controls.Add(this.Bbuscar);
            this.Pbotones.Controls.Add(this.Bcancelar);
            this.Pbotones.Controls.Add(this.Beditar);
            this.Pbotones.Controls.Add(this.Bguardar);
            this.Pbotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pbotones.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pbotones.Location = new System.Drawing.Point(0, 723);
            this.Pbotones.Name = "Pbotones";
            this.Pbotones.Size = new System.Drawing.Size(1081, 100);
            this.Pbotones.TabIndex = 1;
            // 
            // Bnuevo
            // 
            this.Bnuevo.AccessibleDescription = "";
            this.Bnuevo.BackColor = System.Drawing.SystemColors.Window;
            this.Bnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bnuevo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Bnuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.Bnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Bnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Bnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bnuevo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnuevo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Bnuevo.Image = global::Sistema_Inventario.Properties.Resources.agregar;
            this.Bnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bnuevo.Location = new System.Drawing.Point(83, 33);
            this.Bnuevo.Name = "Bnuevo";
            this.Bnuevo.Size = new System.Drawing.Size(108, 43);
            this.Bnuevo.TabIndex = 6;
            this.Bnuevo.Tag = "";
            this.Bnuevo.Text = "&Nuevo";
            this.Bnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltipProducto.SetToolTip(this.Bnuevo, "Agregar nuevo producto");
            this.Bnuevo.UseVisualStyleBackColor = false;
            this.Bnuevo.Click += new System.EventHandler(this.Bnuevo_Click);
            // 
            // Bsalir
            // 
            this.Bsalir.BackColor = System.Drawing.SystemColors.Window;
            this.Bsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bsalir.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Bsalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.Bsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Bsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Bsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bsalir.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsalir.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Bsalir.Image = global::Sistema_Inventario.Properties.Resources.salir_boton;
            this.Bsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bsalir.Location = new System.Drawing.Point(852, 33);
            this.Bsalir.Name = "Bsalir";
            this.Bsalir.Size = new System.Drawing.Size(94, 43);
            this.Bsalir.TabIndex = 5;
            this.Bsalir.Text = "&Salir";
            this.Bsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltipProducto.SetToolTip(this.Bsalir, "Salir del formulario");
            this.Bsalir.UseVisualStyleBackColor = false;
            this.Bsalir.Click += new System.EventHandler(this.Bsalir_Click);
            // 
            // Bbuscar
            // 
            this.Bbuscar.BackColor = System.Drawing.SystemColors.Window;
            this.Bbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bbuscar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Bbuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.Bbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Bbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Bbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bbuscar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bbuscar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Bbuscar.Image = global::Sistema_Inventario.Properties.Resources.buscarboton;
            this.Bbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bbuscar.Location = new System.Drawing.Point(704, 33);
            this.Bbuscar.Name = "Bbuscar";
            this.Bbuscar.Size = new System.Drawing.Size(112, 43);
            this.Bbuscar.TabIndex = 4;
            this.Bbuscar.Text = "&Buscar";
            this.Bbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltipProducto.SetToolTip(this.Bbuscar, "Buscar producto");
            this.Bbuscar.UseVisualStyleBackColor = false;
            this.Bbuscar.Click += new System.EventHandler(this.Bbuscar_Click);
            // 
            // Bcancelar
            // 
            this.Bcancelar.BackColor = System.Drawing.SystemColors.Window;
            this.Bcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bcancelar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Bcancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.Bcancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Bcancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Bcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bcancelar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcancelar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Bcancelar.Image = global::Sistema_Inventario.Properties.Resources.cancelar;
            this.Bcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bcancelar.Location = new System.Drawing.Point(541, 33);
            this.Bcancelar.Name = "Bcancelar";
            this.Bcancelar.Size = new System.Drawing.Size(130, 43);
            this.Bcancelar.TabIndex = 3;
            this.Bcancelar.Text = "&Cancelar";
            this.Bcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltipProducto.SetToolTip(this.Bcancelar, "Cancelar cambios del producto");
            this.Bcancelar.UseVisualStyleBackColor = false;
            this.Bcancelar.Click += new System.EventHandler(this.Bcancelar_Click);
            // 
            // Beditar
            // 
            this.Beditar.BackColor = System.Drawing.SystemColors.Window;
            this.Beditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beditar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Beditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.Beditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Beditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Beditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Beditar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beditar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Beditar.Image = global::Sistema_Inventario.Properties.Resources.editar;
            this.Beditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Beditar.Location = new System.Drawing.Point(399, 33);
            this.Beditar.Name = "Beditar";
            this.Beditar.Size = new System.Drawing.Size(109, 43);
            this.Beditar.TabIndex = 2;
            this.Beditar.Text = "&Editar";
            this.Beditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltipProducto.SetToolTip(this.Beditar, "Editar cambios del producto");
            this.Beditar.UseVisualStyleBackColor = false;
            this.Beditar.Click += new System.EventHandler(this.Beditar_Click);
            // 
            // Bguardar
            // 
            this.Bguardar.BackColor = System.Drawing.SystemColors.Window;
            this.Bguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bguardar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Bguardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.Bguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Bguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Bguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bguardar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bguardar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Bguardar.Image = global::Sistema_Inventario.Properties.Resources.guardar;
            this.Bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bguardar.Location = new System.Drawing.Point(227, 33);
            this.Bguardar.Name = "Bguardar";
            this.Bguardar.Size = new System.Drawing.Size(130, 43);
            this.Bguardar.TabIndex = 1;
            this.Bguardar.Text = "&Guardar";
            this.Bguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltipProducto.SetToolTip(this.Bguardar, "Guardar cambios del producto");
            this.Bguardar.UseVisualStyleBackColor = false;
            this.Bguardar.Click += new System.EventHandler(this.Bguardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id_Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de vencimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "Estado";
            // 
            // TId_producto
            // 
            this.TId_producto.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TId_producto.Location = new System.Drawing.Point(259, 128);
            this.TId_producto.Name = "TId_producto";
            this.TId_producto.ReadOnly = true;
            this.TId_producto.Size = new System.Drawing.Size(251, 39);
            this.TId_producto.TabIndex = 11;
            // 
            // TNombre
            // 
            this.TNombre.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.Location = new System.Drawing.Point(200, 186);
            this.TNombre.Multiline = true;
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(310, 69);
            this.TNombre.TabIndex = 12;
            // 
            // TMarca
            // 
            this.TMarca.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMarca.Location = new System.Drawing.Point(200, 274);
            this.TMarca.Multiline = true;
            this.TMarca.Name = "TMarca";
            this.TMarca.Size = new System.Drawing.Size(310, 72);
            this.TMarca.TabIndex = 13;
            // 
            // CEstado
            // 
            this.CEstado.BackColor = System.Drawing.Color.White;
            this.CEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CEstado.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEstado.FormattingEnabled = true;
            this.CEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CEstado.Location = new System.Drawing.Point(200, 471);
            this.CEstado.Name = "CEstado";
            this.CEstado.Size = new System.Drawing.Size(251, 39);
            this.CEstado.TabIndex = 20;
            // 
            // DFecha_vencimiento
            // 
            this.DFecha_vencimiento.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DFecha_vencimiento.Location = new System.Drawing.Point(340, 380);
            this.DFecha_vencimiento.Name = "DFecha_vencimiento";
            this.DFecha_vencimiento.Size = new System.Drawing.Size(170, 39);
            this.DFecha_vencimiento.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Image = global::Sistema_Inventario.Properties.Resources.agregar_imagen1;
            this.button1.Location = new System.Drawing.Point(864, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 42);
            this.button1.TabIndex = 26;
            this.tooltipProducto.SetToolTip(this.button1, "Agregar imagen del producto");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(581, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 31);
            this.label7.TabIndex = 24;
            this.label7.Text = "Imagen del producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 565);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 31);
            this.label9.TabIndex = 27;
            this.label9.Text = "Existencias";
            // 
            // TExistencia
            // 
            this.TExistencia.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TExistencia.Location = new System.Drawing.Point(259, 562);
            this.TExistencia.Name = "TExistencia";
            this.TExistencia.Size = new System.Drawing.Size(251, 39);
            this.TExistencia.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(587, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 327);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 652);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 31);
            this.label10.TabIndex = 29;
            this.label10.Text = "Precio de venta";
            // 
            // TPrecio_venta
            // 
            this.TPrecio_venta.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPrecio_venta.Location = new System.Drawing.Point(259, 649);
            this.TPrecio_venta.Name = "TPrecio_venta";
            this.TPrecio_venta.Size = new System.Drawing.Size(251, 39);
            this.TPrecio_venta.TabIndex = 30;
            // 
            // TRepresentaciongrafica
            // 
            this.TRepresentaciongrafica.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRepresentaciongrafica.Location = new System.Drawing.Point(584, 649);
            this.TRepresentaciongrafica.Name = "TRepresentaciongrafica";
            this.TRepresentaciongrafica.Size = new System.Drawing.Size(429, 39);
            this.TRepresentaciongrafica.TabIndex = 31;
            this.TRepresentaciongrafica.TextChanged += new System.EventHandler(this.TRepresentaciongrafica_TextChanged);
            // 
            // CId_Categoria
            // 
            this.CId_Categoria.DisplayMember = "Cuidado Personal\r\nVitaminas\r\nDermocosmética\r\nBienestar\r\nBebés\r\nNutrición Deportiv" +
    "a\r\nHerboristería\r\nVeterinaria\r\nOrtopedia\r\nAntialérgicos\r\nAntiácidos\r\nLaxantes";
            this.CId_Categoria.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CId_Categoria.FormattingEnabled = true;
            this.CId_Categoria.Items.AddRange(new object[] {
            "Cuidado Personal",
            "Vitaminas",
            "Dermocosmética",
            "Bienestar",
            "Bebés",
            "Nutrición Deportiva",
            "Herboristería",
            "Veterinaria",
            "Ortopedia",
            "Antialérgicos",
            "Antiácidos",
            "Laxantes"});
            this.CId_Categoria.Location = new System.Drawing.Point(762, 128);
            this.CId_Categoria.Name = "CId_Categoria";
            this.CId_Categoria.Size = new System.Drawing.Size(251, 39);
            this.CId_Categoria.TabIndex = 34;
            this.CId_Categoria.Text = "Medicamentos";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1081, 823);
            this.Controls.Add(this.CId_Categoria);
            this.Controls.Add(this.TRepresentaciongrafica);
            this.Controls.Add(this.TPrecio_venta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TExistencia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DFecha_vencimiento);
            this.Controls.Add(this.CEstado);
            this.Controls.Add(this.TMarca);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TId_producto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pbotones);
            this.Controls.Add(this.Ptitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Producto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Producto_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Producto_FormClosing);
            this.Load += new System.EventHandler(this.Producto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Producto_KeyDown);
            this.Ptitulo.ResumeLayout(false);
            this.Ptitulo.PerformLayout();
            this.Pbotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Ptitulo;
        private System.Windows.Forms.Panel Pbotones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bsalir;
        private System.Windows.Forms.Button Bbuscar;
        private System.Windows.Forms.Button Bcancelar;
        private System.Windows.Forms.Button Beditar;
        private System.Windows.Forms.Button Bguardar;
        private System.Windows.Forms.Button Bnuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TId_producto;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TMarca;
        private System.Windows.Forms.ComboBox CEstado;
        private System.Windows.Forms.DateTimePicker DFecha_vencimiento;
        private System.Windows.Forms.ToolTip tooltipProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TExistencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TPrecio_venta;
        private System.Windows.Forms.TextBox TRepresentaciongrafica;
        private System.Windows.Forms.ComboBox CId_Categoria;
    }
}