﻿namespace FarmSystem.Relatorios
{
	partial class Frm_Relacao_Produtos
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
			this.postgresDataSet1 = new FarmSystem.postgresDataSet1();
			this.postgresDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.postgresDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.postgresDataSet1BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.postgresDataSet1BindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "FarmSystem.Relatorios.Rel_de_Produtos.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(800, 450);
			this.reportViewer1.TabIndex = 0;
			// 
			// postgresDataSet1
			// 
			this.postgresDataSet1.DataSetName = "postgresDataSet1";
			this.postgresDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// postgresDataSet1BindingSource
			// 
			this.postgresDataSet1BindingSource.DataSource = this.postgresDataSet1;
			this.postgresDataSet1BindingSource.Position = 0;
			// 
			// Frm_Relacao_Produtos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.reportViewer1);
			this.Name = "Frm_Relacao_Produtos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Frm_Relacao_Produtos";
			this.Load += new System.EventHandler(this.Frm_Relacao_Produtos_Load);
			((System.ComponentModel.ISupportInitialize)(this.postgresDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.postgresDataSet1BindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource postgresDataSet1BindingSource;
		private postgresDataSet1 postgresDataSet1;
	}
}