namespace FarmSystem.usuario
{
	partial class Frm_Sel_User
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
			this.data_usuario = new System.Windows.Forms.DataGridView();
			this.postgresDataSet = new FarmSystem.postgresDataSet();
			this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.usuarioTableAdapter = new FarmSystem.postgresDataSetTableAdapters.usuarioTableAdapter();
			this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.data_usuario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// data_usuario
			// 
			this.data_usuario.AutoGenerateColumns = false;
			this.data_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn});
			this.data_usuario.DataSource = this.usuarioBindingSource;
			this.data_usuario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.data_usuario.Location = new System.Drawing.Point(0, 0);
			this.data_usuario.Name = "data_usuario";
			this.data_usuario.Size = new System.Drawing.Size(971, 418);
			this.data_usuario.TabIndex = 0;
			this.data_usuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_usuario_CellContentClick);
			this.data_usuario.DoubleClick += new System.EventHandler(this.data_usuario_DoubleClick);
			// 
			// postgresDataSet
			// 
			this.postgresDataSet.DataSetName = "postgresDataSet";
			this.postgresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// usuarioBindingSource
			// 
			this.usuarioBindingSource.DataMember = "usuario";
			this.usuarioBindingSource.DataSource = this.postgresDataSet;
			// 
			// usuarioTableAdapter
			// 
			this.usuarioTableAdapter.ClearBeforeFill = true;
			// 
			// codigoDataGridViewTextBoxColumn
			// 
			this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
			this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
			this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
			// 
			// nomeDataGridViewTextBoxColumn
			// 
			this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
			this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
			this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
			// 
			// rgDataGridViewTextBoxColumn
			// 
			this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
			this.rgDataGridViewTextBoxColumn.HeaderText = "rg";
			this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
			// 
			// cpfDataGridViewTextBoxColumn
			// 
			this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
			this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
			this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
			// 
			// nascimentoDataGridViewTextBoxColumn
			// 
			this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "nascimento";
			this.nascimentoDataGridViewTextBoxColumn.HeaderText = "nascimento";
			this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
			// 
			// idadeDataGridViewTextBoxColumn
			// 
			this.idadeDataGridViewTextBoxColumn.DataPropertyName = "idade";
			this.idadeDataGridViewTextBoxColumn.HeaderText = "idade";
			this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			// 
			// senhaDataGridViewTextBoxColumn
			// 
			this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
			this.senhaDataGridViewTextBoxColumn.HeaderText = "senha";
			this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
			// 
			// enderecoDataGridViewTextBoxColumn
			// 
			this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
			this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
			this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
			// 
			// Frm_Sel_User
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(971, 418);
			this.Controls.Add(this.data_usuario);
			this.Name = "Frm_Sel_User";
			this.Text = "Seleção de Usuários";
			this.Load += new System.EventHandler(this.Frm_Sel_User_Load);
			((System.ComponentModel.ISupportInitialize)(this.data_usuario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView data_usuario;
		private postgresDataSet postgresDataSet;
		private System.Windows.Forms.BindingSource usuarioBindingSource;
		private postgresDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
	}
}