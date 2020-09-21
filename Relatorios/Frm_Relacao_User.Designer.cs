namespace FarmSystem.Relatorios
{
	partial class Frm_Relacao_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Relacao_User));
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmsystemDB = new FarmSystem.FarmsystemDB();
            this.Rp_Usuarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usuarioTableAdapter = new FarmSystem.FarmsystemDBTableAdapters.usuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmsystemDB)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.farmsystemDB;
            // 
            // farmsystemDB
            // 
            this.farmsystemDB.DataSetName = "FarmsystemDB";
            this.farmsystemDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Rp_Usuarios
            // 
            this.Rp_Usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "Rel_Usuario";
            reportDataSource2.Value = this.usuarioBindingSource;
            this.Rp_Usuarios.LocalReport.DataSources.Add(reportDataSource2);
            this.Rp_Usuarios.LocalReport.ReportEmbeddedResource = "FarmSystem.Relatorios.Rel_de_Usuarios.rdlc";
            this.Rp_Usuarios.Location = new System.Drawing.Point(0, 0);
            this.Rp_Usuarios.Name = "Rp_Usuarios";
            this.Rp_Usuarios.ServerReport.BearerToken = null;
            this.Rp_Usuarios.Size = new System.Drawing.Size(800, 450);
            this.Rp_Usuarios.TabIndex = 0;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Relacao_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rp_Usuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Relacao_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmsystemDB)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer Rp_Usuarios;
		private FarmsystemDB farmsystemDB;
		private System.Windows.Forms.BindingSource usuarioBindingSource;
		private FarmsystemDBTableAdapters.usuarioTableAdapter usuarioTableAdapter;
	}
}