namespace FarmSystem.Relatorios
{
	partial class Frm_Relacao_Fornecedores
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.Rp_Fornecedores = new Microsoft.Reporting.WinForms.ReportViewer();
			this.farmsystemDB = new FarmSystem.FarmsystemDB();
			this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fornecedorTableAdapter = new FarmSystem.FarmsystemDBTableAdapters.fornecedorTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.farmsystemDB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// Rp_Fornecedores
			// 
			this.Rp_Fornecedores.AutoSize = true;
			this.Rp_Fornecedores.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource2.Name = "Fornecedores";
			reportDataSource2.Value = this.fornecedorBindingSource;
			this.Rp_Fornecedores.LocalReport.DataSources.Add(reportDataSource2);
			this.Rp_Fornecedores.LocalReport.ReportEmbeddedResource = "FarmSystem.Relatorios.Rel_de Fornecedores.rdlc";
			this.Rp_Fornecedores.Location = new System.Drawing.Point(0, 0);
			this.Rp_Fornecedores.Name = "Rp_Fornecedores";
			this.Rp_Fornecedores.ServerReport.BearerToken = null;
			this.Rp_Fornecedores.Size = new System.Drawing.Size(800, 450);
			this.Rp_Fornecedores.TabIndex = 0;
			// 
			// farmsystemDB
			// 
			this.farmsystemDB.DataSetName = "FarmsystemDB";
			this.farmsystemDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// fornecedorBindingSource
			// 
			this.fornecedorBindingSource.DataMember = "fornecedor";
			this.fornecedorBindingSource.DataSource = this.farmsystemDB;
			// 
			// fornecedorTableAdapter
			// 
			this.fornecedorTableAdapter.ClearBeforeFill = true;
			// 
			// Frm_Relacao_Fornecedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Rp_Fornecedores);
			this.Name = "Frm_Relacao_Fornecedores";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Frm_Relacao_Fornecedores_Load);
			((System.ComponentModel.ISupportInitialize)(this.farmsystemDB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer Rp_Fornecedores;
		private FarmsystemDB farmsystemDB;
		private System.Windows.Forms.BindingSource fornecedorBindingSource;
		private FarmsystemDBTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
	}
}