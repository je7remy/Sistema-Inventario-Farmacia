
namespace Sistema_Inventario
{
    partial class FReporteEmpleado
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
            this.DBInventarioDataSet = new Sistema_Inventario.DBInventarioDataSet();
            this.EmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpleadoTableAdapter = new Sistema_Inventario.DBInventarioDataSetTableAdapters.EmpleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DBInventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Inventario.Empleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DBInventarioDataSet
            // 
            this.DBInventarioDataSet.DataSetName = "DBInventarioDataSet";
            this.DBInventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpleadoBindingSource
            // 
            this.EmpleadoBindingSource.DataMember = "Empleado";
            this.EmpleadoBindingSource.DataSource = this.DBInventarioDataSet;
            // 
            // EmpleadoTableAdapter
            // 
            this.EmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // FReporteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FReporteEmpleado";
            this.Text = "Reporte Empleado";
            this.Load += new System.EventHandler(this.FReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBInventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EmpleadoBindingSource;
        private DBInventarioDataSet DBInventarioDataSet;
        private DBInventarioDataSetTableAdapters.EmpleadoTableAdapter EmpleadoTableAdapter;
    }
}