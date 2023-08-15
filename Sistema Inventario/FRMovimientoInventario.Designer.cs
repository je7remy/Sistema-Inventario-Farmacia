
namespace Sistema_Inventario
{
    partial class FRMovimientoInventario
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
            this.DBInventarioMovimientoInventario = new Sistema_Inventario.DBInventarioMovimientoInventario();
            this.Movimiento_InventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Movimiento_InventarioTableAdapter = new Sistema_Inventario.DBInventarioMovimientoInventarioTableAdapters.Movimiento_InventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DBInventarioMovimientoInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movimiento_InventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Movimiento_Inventario";
            reportDataSource1.Value = this.Movimiento_InventarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Inventario.RMovimientoInventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DBInventarioMovimientoInventario
            // 
            this.DBInventarioMovimientoInventario.DataSetName = "DBInventarioMovimientoInventario";
            this.DBInventarioMovimientoInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Movimiento_InventarioBindingSource
            // 
            this.Movimiento_InventarioBindingSource.DataMember = "Movimiento_Inventario";
            this.Movimiento_InventarioBindingSource.DataSource = this.DBInventarioMovimientoInventario;
            // 
            // Movimiento_InventarioTableAdapter
            // 
            this.Movimiento_InventarioTableAdapter.ClearBeforeFill = true;
            // 
            // FRMovimientoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMovimientoInventario";
            this.Text = "FRMovimientoInventario";
            this.Load += new System.EventHandler(this.FRMovimientoInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBInventarioMovimientoInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movimiento_InventarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Movimiento_InventarioBindingSource;
        private DBInventarioMovimientoInventario DBInventarioMovimientoInventario;
        private DBInventarioMovimientoInventarioTableAdapters.Movimiento_InventarioTableAdapter Movimiento_InventarioTableAdapter;
    }
}