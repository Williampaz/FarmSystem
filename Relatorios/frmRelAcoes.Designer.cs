﻿namespace FarmSystem
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelAcoes));
            this.acoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postgresDataSet2 = new FarmSystem.postgresDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnListaPlant = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsemente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtplantacao = new System.Windows.Forms.TextBox();
            this.acoes_plantacaoTableAdapter = new FarmSystem.postgresDataSet2TableAdapters.acoes_plantacaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.acoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // acoesBindingSource
            // 
            this.acoesBindingSource.DataMember = "acoes_plantacao";
            this.acoesBindingSource.DataSource = this.postgresDataSet2;
            // 
            // postgresDataSet2
            // 
            this.postgresDataSet2.DataSetName = "postgresDataSet2";
            this.postgresDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.acoesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FarmSystem.Relatorios.relAcoes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1361, 622);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(534, 21);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(80, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnListaPlant
            // 
            this.btnListaPlant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaPlant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaPlant.Location = new System.Drawing.Point(101, 21);
            this.btnListaPlant.Name = "btnListaPlant";
            this.btnListaPlant.Size = new System.Drawing.Size(46, 23);
            this.btnListaPlant.TabIndex = 15;
            this.btnListaPlant.Text = "Listar";
            this.btnListaPlant.UseVisualStyleBackColor = true;
            this.btnListaPlant.Click += new System.EventHandler(this.btnListaPlant_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Semente Utilizada:";
            // 
            // txtsemente
            // 
            this.txtsemente.AcceptsReturn = true;
            this.txtsemente.Location = new System.Drawing.Point(153, 25);
            this.txtsemente.Name = "txtsemente";
            this.txtsemente.Size = new System.Drawing.Size(372, 20);
            this.txtsemente.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Plantação:";
            // 
            // txtplantacao
            // 
            this.txtplantacao.Location = new System.Drawing.Point(15, 24);
            this.txtplantacao.Name = "txtplantacao";
            this.txtplantacao.Size = new System.Drawing.Size(82, 20);
            this.txtplantacao.TabIndex = 17;
            // 
            // acoes_plantacaoTableAdapter
            // 
            this.acoes_plantacaoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelAcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1362, 681);
            this.Controls.Add(this.btnListaPlant);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsemente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtplantacao);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnListaPlant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsemente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtplantacao;
        private postgresDataSet2TableAdapters.acoes_plantacaoTableAdapter acoes_plantacaoTableAdapter;
    }
}