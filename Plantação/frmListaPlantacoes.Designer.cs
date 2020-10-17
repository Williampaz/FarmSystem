namespace FarmSystem
{
    partial class frmListaPlantacoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvPlantacoes = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Área = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plantio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Previsao_Colheita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Colheita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtide_Colhida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacolhida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(267, 13);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(446, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // dgvPlantacoes
            // 
            this.dgvPlantacoes.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvPlantacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlantacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Funcionário,
            this.Área,
            this.Distancia,
            this.Plantio,
            this.Valor_Venda,
            this.Status,
            this.Previsao_Colheita,
            this.Data_Colheita,
            this.Qtide_Colhida,
            this.Semente,
            this.datacolhida});
            this.dgvPlantacoes.Location = new System.Drawing.Point(1, 45);
            this.dgvPlantacoes.Name = "dgvPlantacoes";
            this.dgvPlantacoes.Size = new System.Drawing.Size(1122, 448);
            this.dgvPlantacoes.TabIndex = 2;
            this.dgvPlantacoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlantacoes_CellDoubleClick);
            // 
            // Código
            // 
            this.Código.DataPropertyName = "codigo";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 70;
            // 
            // Funcionário
            // 
            this.Funcionário.DataPropertyName = "funcionario";
            this.Funcionário.HeaderText = "Funcionário";
            this.Funcionário.Name = "Funcionário";
            this.Funcionário.Width = 70;
            // 
            // Área
            // 
            this.Área.DataPropertyName = "area";
            this.Área.HeaderText = "Área";
            this.Área.Name = "Área";
            this.Área.Width = 70;
            // 
            // Distancia
            // 
            this.Distancia.DataPropertyName = "distinciaentreplantas";
            this.Distancia.HeaderText = "Distância das Plantas";
            this.Distancia.Name = "Distancia";
            this.Distancia.Width = 70;
            // 
            // Plantio
            // 
            this.Plantio.DataPropertyName = "datadeplantio";
            this.Plantio.HeaderText = "Data Plantio";
            this.Plantio.Name = "Plantio";
            this.Plantio.Width = 90;
            // 
            // Valor_Venda
            // 
            this.Valor_Venda.DataPropertyName = "valordevenda";
            this.Valor_Venda.HeaderText = "Valor Venda";
            this.Valor_Venda.Name = "Valor_Venda";
            this.Valor_Venda.Width = 80;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "statusdaplantacao";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 120;
            // 
            // Previsao_Colheita
            // 
            this.Previsao_Colheita.DataPropertyName = "previsaodecolheita";
            this.Previsao_Colheita.HeaderText = "Prev. Colheita";
            this.Previsao_Colheita.Name = "Previsao_Colheita";
            // 
            // Data_Colheita
            // 
            this.Data_Colheita.DataPropertyName = "prevdatacolheita";
            this.Data_Colheita.HeaderText = "Data Colheita";
            this.Data_Colheita.Name = "Data_Colheita";
            this.Data_Colheita.Width = 80;
            // 
            // Qtide_Colhida
            // 
            this.Qtide_Colhida.DataPropertyName = "quantidadecolhida";
            this.Qtide_Colhida.HeaderText = "Qtide Colhida";
            this.Qtide_Colhida.Name = "Qtide_Colhida";
            this.Qtide_Colhida.Width = 80;
            // 
            // Semente
            // 
            this.Semente.DataPropertyName = "sementeusada";
            this.Semente.HeaderText = "Semente";
            this.Semente.Name = "Semente";
            this.Semente.Width = 120;
            // 
            // datacolhida
            // 
            this.datacolhida.DataPropertyName = "datadecolheita";
            this.datacolhida.HeaderText = "Data Colhida";
            this.datacolhida.Name = "datacolhida";
            // 
            // frmListaPlantacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1128, 494);
            this.Controls.Add(this.dgvPlantacoes);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmListaPlantacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Plantações";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvPlantacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Área;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plantio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Previsao_Colheita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Colheita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtide_Colhida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semente;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacolhida;
    }
}