namespace FarmSystem
{
    partial class frmRelAcoes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.acoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postgresDataSet2 = new FarmSystem.postgresDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.acoesTableAdapter = new FarmSystem.postgresDataSet2TableAdapters.acoesTableAdapter();
            this.cbbPlantacao = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.acoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // acoesBindingSource
            // 
            this.acoesBindingSource.DataMember = "acoes";
            this.acoesBindingSource.DataSource = this.postgresDataSet2;
            // 
            // postgresDataSet2
            // 
            this.postgresDataSet2.DataSetName = "postgresDataSet2";
            this.postgresDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.acoesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FarmSystem.Relatorios.relAcoes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 36);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 414);
            this.reportViewer1.TabIndex = 0;
            // 
            // acoesTableAdapter
            // 
            this.acoesTableAdapter.ClearBeforeFill = true;
            // 
            // cbbPlantacao
            // 
            this.cbbPlantacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbPlantacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbPlantacao.FormattingEnabled = true;
            this.cbbPlantacao.Location = new System.Drawing.Point(91, 9);
            this.cbbPlantacao.Name = "cbbPlantacao";
            this.cbbPlantacao.Size = new System.Drawing.Size(121, 21);
            this.cbbPlantacao.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(230, 7);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(80, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.Location = new System.Drawing.Point(325, 7);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(201, 23);
            this.btnTodos.TabIndex = 3;
            this.btnTodos.Text = "Mostrar todas as ações";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plantação:";
            // 
            // frmRelAcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cbbPlantacao);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelAcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório das Ações";
            this.Load += new System.EventHandler(this.frmRelAcoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource acoesBindingSource;
        private postgresDataSet2 postgresDataSet2;
        private postgresDataSet2TableAdapters.acoesTableAdapter acoesTableAdapter;
        private System.Windows.Forms.ComboBox cbbPlantacao;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Label label1;
    }
}