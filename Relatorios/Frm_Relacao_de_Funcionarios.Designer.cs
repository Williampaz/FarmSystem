namespace FarmSystem.Relatorios
{
	partial class Frm_Relacao_de_Funcionarios
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
			this.Rp_Funcionarios = new Microsoft.Reporting.WinForms.ReportViewer();
			this.farmsystemDB = new FarmSystem.FarmsystemDB();
			this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.funcionarioTableAdapter = new FarmSystem.FarmsystemDBTableAdapters.funcionarioTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.farmsystemDB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// Rp_Funcionarios
			// 
			this.Rp_Funcionarios.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource2.Name = "Funcionario";
			reportDataSource2.Value = this.funcionarioBindingSource;
			this.Rp_Funcionarios.LocalReport.DataSources.Add(reportDataSource2);
			this.Rp_Funcionarios.LocalReport.ReportEmbeddedResource = "FarmSystem.Relatorios.Rel_de_Funcionario.rdlc";
			this.Rp_Funcionarios.Location = new System.Drawing.Point(0, 0);
			this.Rp_Funcionarios.Name = "Rp_Funcionarios";
			this.Rp_Funcionarios.ServerReport.BearerToken = null;
			this.Rp_Funcionarios.Size = new System.Drawing.Size(800, 450);
			this.Rp_Funcionarios.TabIndex = 0;
			// 
			// farmsystemDB
			// 
			this.farmsystemDB.DataSetName = "FarmsystemDB";
			this.farmsystemDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// funcionarioBindingSource
			// 
			this.funcionarioBindingSource.DataMember = "funcionario";
			this.funcionarioBindingSource.DataSource = this.farmsystemDB;
			// 
			// funcionarioTableAdapter
			// 
			this.funcionarioTableAdapter.ClearBeforeFill = true;
			// 
			// Frm_Relacao_de_Funcionarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Rp_Funcionarios);
			this.Name = "Frm_Relacao_de_Funcionarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Frm_Relacao_de_Funcionarios";
			this.Load += new System.EventHandler(this.Frm_Relacao_de_Funcionarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.farmsystemDB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer Rp_Funcionarios;
		private FarmsystemDB farmsystemDB;
		private System.Windows.Forms.BindingSource funcionarioBindingSource;
		private FarmsystemDBTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
	}
}