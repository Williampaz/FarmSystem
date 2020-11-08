namespace FarmSystem
{
    partial class frmListaAcoes
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
            this.dgvAcoes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plantação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAcoes
            // 
            this.dgvAcoes.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvAcoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Ação,
            this.Plantação,
            this.Produto,
            this.Data,
            this.Funcionário,
            this.Status,
            this.horario,
            this.quantidade});
            this.dgvAcoes.Location = new System.Drawing.Point(1, 61);
            this.dgvAcoes.Name = "dgvAcoes";
            this.dgvAcoes.Size = new System.Drawing.Size(1054, 425);
            this.dgvAcoes.TabIndex = 0;
            this.dgvAcoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcoes_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(202, 20);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(494, 20);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // Código
            // 
            this.Código.DataPropertyName = "codigo";
            this.Código.HeaderText = "Codigo";
            this.Código.Name = "Código";
            this.Código.Width = 80;
            // 
            // Ação
            // 
            this.Ação.DataPropertyName = "tipoac";
            this.Ação.HeaderText = "Acao";
            this.Ação.Name = "Ação";
            this.Ação.Width = 250;
            // 
            // Plantação
            // 
            this.Plantação.DataPropertyName = "plantacao";
            this.Plantação.HeaderText = "Plantacao";
            this.Plantação.Name = "Plantação";
            this.Plantação.Width = 80;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "codigoprod";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.Width = 80;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "dataac";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Funcionário
            // 
            this.Funcionário.DataPropertyName = "funcionario";
            this.Funcionário.HeaderText = "Funcionario";
            this.Funcionário.Name = "Funcionário";
            this.Funcionário.Width = 80;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 130;
            // 
            // horario
            // 
            this.horario.DataPropertyName = "horario";
            this.horario.HeaderText = "Horário";
            this.horario.Name = "horario";
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.Width = 90;
            // 
            // frmListaAcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1068, 486);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAcoes);
            this.MaximizeBox = false;
            this.Name = "frmListaAcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Ações";
            this.Load += new System.EventHandler(this.frmListaAcoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAcoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plantação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
    }
}