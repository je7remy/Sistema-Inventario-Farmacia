
namespace Sistema_Inventario
{
    partial class FRProducto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DBInventarioProducto = new Sistema_Inventario.DBInventarioProducto();
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductoTableAdapter = new Sistema_Inventario.DBInventarioProductoTableAdapters.ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DBInventarioProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Producto";
            reportDataSource1.Value = this.ProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Inventario.RProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DBInventarioProducto
            // 
            this.DBInventarioProducto.DataSetName = "DBInventarioProducto";
            this.DBInventarioProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataMember = "Producto";
            this.ProductoBindingSource.DataSource = this.DBInventarioProducto;
            // 
            // ProductoTableAdapter
            // 
            this.ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // FRProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRProducto";
            this.Text = "FRProducto";
            this.Load += new System.EventHandler(this.FRProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBInventarioProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private DBInventarioProducto DBInventarioProducto;
        private DBInventarioProductoTableAdapters.ProductoTableAdapter ProductoTableAdapter;
    }
}