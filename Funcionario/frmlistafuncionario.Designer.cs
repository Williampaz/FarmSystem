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
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvfuncionarios = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataadmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionarios)).BeginInit();
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
            // dgvfuncionarios
            // 
            this.dgvfuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.idade,
            this.datanascimento,
            this.telefone,
            this.endereco,
            this.dataadmissao,
            this.cargo,
            this.salario});
            this.dgvfuncionarios.Location = new System.Drawing.Point(12, 51);
            this.dgvfuncionarios.Name = "dgvfuncionarios";
            this.dgvfuncionarios.Size = new System.Drawing.Size(1233, 450);
            this.dgvfuncionarios.TabIndex = 9;
            this.dgvfuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfuncionarios_CellContentClick_2);
            this.dgvfuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfuncionarios_CellDoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.Width = 90;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 180;
            // 
            // idade
            // 
            this.idade.DataPropertyName = "idade";
            this.idade.HeaderText = "Idade";
            this.idade.Name = "idade";
            this.idade.Width = 80;
            // 
            // datanascimento
            // 
            this.datanascimento.DataPropertyName = "nascimento";
            this.datanascimento.HeaderText = "Data Nacimento";
            this.datanascimento.Name = "datanascimento";
            this.datanascimento.Width = 110;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "fone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.Width = 110;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.Width = 260;
            // 
            // dataadmissao
            // 
            this.dataadmissao.DataPropertyName = "dataadmissao";
            this.dataadmissao.HeaderText = "Data Admissão";
            this.dataadmissao.Name = "dataadmissao";
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "cargo";
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.Width = 150;
            // 
            // salario
            // 
            this.salario.DataPropertyName = "salario";
            this.salario.HeaderText = "Salario";
            this.salario.Name = "salario";
            this.salario.Width = 110;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvfuncionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataadmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
    }
}