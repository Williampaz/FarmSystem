namespace FarmSystem.Funcionario
{
    partial class frmlistafuncionario
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
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.farmsystemDB = new FarmSystem.FarmsystemDB();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new FarmSystem.FarmsystemDBTableAdapters.funcionarioTableAdapter();
            this.dgvfuncionarios = new System.Windows.Forms.DataGridView();
            this.funcionarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.farmsystemDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(66, 12);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(745, 20);
            this.txtpesquisa.TabIndex = 8;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtPesquisarForn_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Procurar:";
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
            // dgvfuncionarios
            // 
            this.dgvfuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvfuncionarios.Location = new System.Drawing.Point(13, 38);
            this.dgvfuncionarios.Name = "dgvfuncionarios";
            this.dgvfuncionarios.Size = new System.Drawing.Size(1067, 314);
            this.dgvfuncionarios.TabIndex = 9;
            this.dgvfuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfuncionarios_CellContentClick_3);
            this.dgvfuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfuncionarios_CellDoubleClick_2);
            // 
            // funcionarioBindingSource1
            // 
            this.funcionarioBindingSource1.DataMember = "funcionario";
            this.funcionarioBindingSource1.DataSource = this.farmsystemDB;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "codigo";
            this.Column1.HeaderText = "codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nome";
            this.Column2.HeaderText = "nome";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "idade";
            this.Column3.HeaderText = "idade";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "datanasc";
            this.Column4.HeaderText = "nascimento";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "fone";
            this.Column5.HeaderText = "fone";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "endereco";
            this.Column6.HeaderText = "endereço";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "cargo";
            this.Column7.HeaderText = "cargo";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "salario";
            this.Column8.HeaderText = "salario";
            this.Column8.Name = "Column8";
            // 
            // frmlistafuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 513);
            this.Controls.Add(this.dgvfuncionarios);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.label1);
            this.Name = "frmlistafuncionario";
            this.Text = "frmlistafuncionario";
            this.Load += new System.EventHandler(this.frmlistafuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.farmsystemDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label1;
        private FarmsystemDB farmsystemDB;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private FarmsystemDBTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.DataGridView dgvfuncionarios;
        private System.Windows.Forms.BindingSource funcionarioBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}