
namespace Sistema_Inventario
{
    partial class Categoria
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
            this.TId_Categoria = new System.Windows.Forms.TextBox();
            this.TDescripcion = new System.Windows.Forms.TextBox();
            this.toolTipempleado = new System.Windows.Forms.ToolTip(this.components);
            this.CNombre_Categoria = new System.Windows.Forms.ComboBox();
            this.Ptitulo.SuspendLayout();
            this.Pbotones.SuspendLayout();
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
            this.Ptitulo.Size = new System.Drawing.Size(1043, 100);
            this.Ptitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento Categoria";
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
            this.Pbotones.Location = new System.Drawing.Point(0, 451);
            this.Pbotones.Name = "Pbotones";
            this.Pbotones.Size = new System.Drawing.Size(1043, 100);
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
            this.toolTipempleado.SetToolTip(this.Bnuevo, "Agregar nueva categoria");
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
            this.toolTipempleado.SetToolTip(this.Bsalir, "Salir del formulario");
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
            this.toolTipempleado.SetToolTip(this.Bbuscar, "Buscar categoria");
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
            this.toolTipempleado.SetToolTip(this.Bcancelar, "Cancelar cambios de categoria");
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
            this.toolTipempleado.SetToolTip(this.Beditar, "Editar cambios de categoria");
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
            this.toolTipempleado.SetToolTip(this.Bguardar, "Guardar cambios de categoria");
            this.Bguardar.UseVisualStyleBackColor = false;
            this.Bguardar.Click += new System.EventHandler(this.Bguardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id_Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descripcion";
            // 
            // TId_Categoria
            // 
            this.TId_Categoria.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TId_Categoria.Location = new System.Drawing.Point(241, 141);
            this.TId_Categoria.Name = "TId_Categoria";
            this.TId_Categoria.ReadOnly = true;
            this.TId_Categoria.Size = new System.Drawing.Size(255, 39);
            this.TId_Categoria.TabIndex = 12;
            // 
            // TDescripcion
            // 
            this.TDescripcion.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDescripcion.Location = new System.Drawing.Point(259, 250);
            this.TDescripcion.Multiline = true;
            this.TDescripcion.Name = "TDescripcion";
            this.TDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TDescripcion.Size = new System.Drawing.Size(724, 147);
            this.TDescripcion.TabIndex = 14;
            // 
            // CNombre_Categoria
            // 
            this.CNombre_Categoria.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNombre_Categoria.FormattingEnabled = true;
            this.CNombre_Categoria.Items.AddRange(new object[] {
            "Analgésicos",
            "Antiácidos",
            "Antiulcerosos",
            "Antialérgicos",
            "Antidiarreicos",
            "Laxantes",
            "Antiinfecciosos"});
            this.CNombre_Categoria.Location = new System.Drawing.Point(717, 141);
            this.CNombre_Categoria.Name = "CNombre_Categoria";
            this.CNombre_Categoria.Size = new System.Drawing.Size(255, 39);
            this.CNombre_Categoria.TabIndex = 15;
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1043, 551);
            this.Controls.Add(this.CNombre_Categoria);
            this.Controls.Add(this.TDescripcion);
            this.Controls.Add(this.TId_Categoria);
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
            this.Name = "Categoria";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.Activated += new System.EventHandler(this.Categoria_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Categoria_FormClosing);
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Categoria_KeyDown);
            this.Ptitulo.ResumeLayout(false);
            this.Ptitulo.PerformLayout();
            this.Pbotones.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox TId_Categoria;
        private System.Windows.Forms.TextBox TDescripcion;
        private System.Windows.Forms.ToolTip toolTipempleado;
        private System.Windows.Forms.ComboBox CNombre_Categoria;
    }
}