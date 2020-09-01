namespace FarmSystem.Produtos
{
	partial class Frmlistaproduto
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
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgprod = new System.Windows.Forms.DataGridView();
            this.postgresDataSet1 = new FarmSystem.postgresDataSet1();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new FarmSystem.postgresDataSet1TableAdapters.produtosTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigofornDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesdeusoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesdeplantioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diacolheitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precokguniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgprod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbusca
            // 
            this.txtbusca.Location = new System.Drawing.Point(80, 28);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(690, 20);
            this.txtbusca.TabIndex = 5;
            this.txtbusca.TextChanged += new System.EventHandler(this.txtbusca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Procurar:";
            // 
            // dvgprod
            // 
            this.dvgprod.AutoGenerateColumns = false;
            this.dvgprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgprod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.codigofornDataGridViewTextBoxColumn,
            this.tipoprodDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.mesdeusoDataGridViewTextBoxColumn,
            this.validadeDataGridViewTextBoxColumn,
            this.mesdeplantioDataGridViewTextBoxColumn,
            this.diacolheitaDataGridViewTextBoxColumn,
            this.precokguniDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dvgprod.DataSource = this.produtosBindingSource;
            this.dvgprod.Location = new System.Drawing.Point(12, 67);
            this.dvgprod.Name = "dvgprod";
            this.dvgprod.Size = new System.Drawing.Size(1300, 371);
            this.dvgprod.TabIndex = 3;
            this.dvgprod.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgprod_CellDoubleClick);
            // 
            // postgresDataSet1
            // 
            this.postgresDataSet1.DataSetName = "postgresDataSet1";
            this.postgresDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.postgresDataSet1;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // codigofornDataGridViewTextBoxColumn
            // 
            this.codigofornDataGridViewTextBoxColumn.DataPropertyName = "codigoforn";
            this.codigofornDataGridViewTextBoxColumn.HeaderText = "codigoforn";
            this.codigofornDataGridViewTextBoxColumn.Name = "codigofornDataGridViewTextBoxColumn";
            // 
            // tipoprodDataGridViewTextBoxColumn
            // 
            this.tipoprodDataGridViewTextBoxColumn.DataPropertyName = "tipoprod";
            this.tipoprodDataGridViewTextBoxColumn.HeaderText = "tipoprod";
            this.tipoprodDataGridViewTextBoxColumn.Name = "tipoprodDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // mesdeusoDataGridViewTextBoxColumn
            // 
            this.mesdeusoDataGridViewTextBoxColumn.DataPropertyName = "mesdeuso";
            this.mesdeusoDataGridViewTextBoxColumn.HeaderText = "mesdeuso";
            this.mesdeusoDataGridViewTextBoxColumn.Name = "mesdeusoDataGridViewTextBoxColumn";
            // 
            // validadeDataGridViewTextBoxColumn
            // 
            this.validadeDataGridViewTextBoxColumn.DataPropertyName = "validade";
            this.validadeDataGridViewTextBoxColumn.HeaderText = "validade";
            this.validadeDataGridViewTextBoxColumn.Name = "validadeDataGridViewTextBoxColumn";
            // 
            // mesdeplantioDataGridViewTextBoxColumn
            // 
            this.mesdeplantioDataGridViewTextBoxColumn.DataPropertyName = "mesdeplantio";
            this.mesdeplantioDataGridViewTextBoxColumn.HeaderText = "mesdeplantio";
            this.mesdeplantioDataGridViewTextBoxColumn.Name = "mesdeplantioDataGridViewTextBoxColumn";
            // 
            // diacolheitaDataGridViewTextBoxColumn
            // 
            this.diacolheitaDataGridViewTextBoxColumn.DataPropertyName = "diacolheita";
            this.diacolheitaDataGridViewTextBoxColumn.HeaderText = "diacolheita";
            this.diacolheitaDataGridViewTextBoxColumn.Name = "diacolheitaDataGridViewTextBoxColumn";
            // 
            // precokguniDataGridViewTextBoxColumn
            // 
            this.precokguniDataGridViewTextBoxColumn.DataPropertyName = "precokg_uni";
            this.precokguniDataGridViewTextBoxColumn.HeaderText = "precokg_uni";
            this.precokguniDataGridViewTextBoxColumn.Name = "precokguniDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // Frmlistaproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 450);
            this.Controls.Add(this.txtbusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgprod);
            this.Name = "Frmlistaproduto";
            this.Text = "Frmlistaproduto";
            this.Load += new System.EventHandler(this.Frmlistaproduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgprod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtbusca;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dvgprod;
        private postgresDataSet1 postgresDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private postgresDataSet1TableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigofornDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesdeusoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesdeplantioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diacolheitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precokguniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}