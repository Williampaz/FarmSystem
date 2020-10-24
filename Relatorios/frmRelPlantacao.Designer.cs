namespace FarmSystem
{
    partial class frmRelPlantacao
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
            this.postgresDataSet3 = new FarmSystem.postgresDataSet3();
            this.plantacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantacaoTableAdapter = new FarmSystem.postgresDataSet3TableAdapters.plantacaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "plantacaoDataSet";
            reportDataSource1.Value = this.plantacaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FarmSystem.Relatorios.relPlantacao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // postgresDataSet3
            // 
            this.postgresDataSet3.DataSetName = "postgresDataSet3";
            this.postgresDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plantacaoBindingSource
            // 
            this.plantacaoBindingSource.DataMember = "plantacao";
            this.plantacaoBindingSource.DataSource = this.postgresDataSet3;
            // 
            // plantacaoTableAdapter
            // 
            this.plantacaoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelPlantacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelPlantacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Plantações";
            this.Load += new System.EventHandler(this.frmRelPlantacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantacaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource plantacaoBindingSource;
        private postgresDataSet3 postgresDataSet3;
        private postgresDataSet3TableAdapters.plantacaoTableAdapter plantacaoTableAdapter;
    }
}