namespace FarmSystem.Fornecedor
{
	partial class frmCadastroFornecedor
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
			this.label3 = new System.Windows.Forms.Label();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.txtEndFornecedor = new System.Windows.Forms.TextBox();
			this.txtEmailFornecedor = new System.Windows.Forms.TextBox();
			this.txtCidadeFornecedor = new System.Windows.Forms.TextBox();
			this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
			this.txtCodFornecedor = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
			this.txtFoneFornecedor = new System.Windows.Forms.MaskedTextBox();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnSelecionarForn = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.epdFornecedor = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.epdFornecedor)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(501, 262);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 16);
			this.label3.TabIndex = 64;
			this.label3.Text = "Fone:";
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackgroundImage = global::FarmSystem.Properties.Resources.clean;
			this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(690, 321);
			this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(173, 70);
			this.btnLimpar.TabIndex = 10;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// txtEndFornecedor
			// 
			this.txtEndFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEndFornecedor.Location = new System.Drawing.Point(18, 163);
			this.txtEndFornecedor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtEndFornecedor.MaxLength = 120;
			this.txtEndFornecedor.Multiline = true;
			this.txtEndFornecedor.Name = "txtEndFornecedor";
			this.txtEndFornecedor.Size = new System.Drawing.Size(649, 89);
			this.txtEndFornecedor.TabIndex = 1;
			this.txtEndFornecedor.Leave += new System.EventHandler(this.txtEndFornecedor_Leave);
			// 
			// txtEmailFornecedor
			// 
			this.txtEmailFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmailFornecedor.Location = new System.Drawing.Point(20, 347);
			this.txtEmailFornecedor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtEmailFornecedor.MaxLength = 300;
			this.txtEmailFornecedor.Name = "txtEmailFornecedor";
			this.txtEmailFornecedor.Size = new System.Drawing.Size(647, 22);
			this.txtEmailFornecedor.TabIndex = 5;
			this.txtEmailFornecedor.Leave += new System.EventHandler(this.txtEmailFornecedor_Leave);
			// 
			// txtCidadeFornecedor
			// 
			this.txtCidadeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCidadeFornecedor.Location = new System.Drawing.Point(18, 282);
			this.txtCidadeFornecedor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtCidadeFornecedor.MaxLength = 120;
			this.txtCidadeFornecedor.Name = "txtCidadeFornecedor";
			this.txtCidadeFornecedor.Size = new System.Drawing.Size(263, 22);
			this.txtCidadeFornecedor.TabIndex = 2;
			this.txtCidadeFornecedor.Leave += new System.EventHandler(this.txtCidadeFornecedor_Leave);
			// 
			// txtNomeFornecedor
			// 
			this.txtNomeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNomeFornecedor.Location = new System.Drawing.Point(20, 105);
			this.txtNomeFornecedor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtNomeFornecedor.MaxLength = 80;
			this.txtNomeFornecedor.Name = "txtNomeFornecedor";
			this.txtNomeFornecedor.Size = new System.Drawing.Size(647, 22);
			this.txtNomeFornecedor.TabIndex = 0;
			this.txtNomeFornecedor.Leave += new System.EventHandler(this.txtNomeFornecedor_Leave);
			// 
			// txtCodFornecedor
			// 
			this.txtCodFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCodFornecedor.Location = new System.Drawing.Point(18, 43);
			this.txtCodFornecedor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtCodFornecedor.Name = "txtCodFornecedor";
			this.txtCodFornecedor.ReadOnly = true;
			this.txtCodFornecedor.Size = new System.Drawing.Size(420, 22);
			this.txtCodFornecedor.TabIndex = 53;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 142);
			this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 16);
			this.label9.TabIndex = 52;
			this.label9.Text = "Endereço:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(19, 326);
			this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 51;
			this.label7.Text = "E-mail:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 262);
			this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 16);
			this.label6.TabIndex = 50;
			this.label6.Text = "Cidade:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(308, 262);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 16);
			this.label4.TabIndex = 49;
			this.label4.Text = "CNPJ:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 85);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 16);
			this.label2.TabIndex = 48;
			this.label2.Text = "Nome:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 16);
			this.label1.TabIndex = 47;
			this.label1.Text = "Código:";
			// 
			// txtCnpj
			// 
			this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCnpj.Location = new System.Drawing.Point(311, 282);
			this.txtCnpj.Margin = new System.Windows.Forms.Padding(4);
			this.txtCnpj.Mask = "00.000.000/0000-00";
			this.txtCnpj.Name = "txtCnpj";
			this.txtCnpj.Size = new System.Drawing.Size(165, 22);
			this.txtCnpj.TabIndex = 3;
			this.txtCnpj.Leave += new System.EventHandler(this.txtCnpj_Leave);
			// 
			// txtFoneFornecedor
			// 
			this.txtFoneFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFoneFornecedor.Location = new System.Drawing.Point(504, 282);
			this.txtFoneFornecedor.Margin = new System.Windows.Forms.Padding(4);
			this.txtFoneFornecedor.Mask = "(99) 00000-0000";
			this.txtFoneFornecedor.Name = "txtFoneFornecedor";
			this.txtFoneFornecedor.Size = new System.Drawing.Size(162, 22);
			this.txtFoneFornecedor.TabIndex = 4;
			this.txtFoneFornecedor.Leave += new System.EventHandler(this.txtFoneFornecedor_Leave);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackgroundImage = global::FarmSystem.Properties.Resources.delete;
			this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(690, 244);
			this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(173, 70);
			this.btnExcluir.TabIndex = 9;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.Honeydew;
			this.btnEditar.BackgroundImage = global::FarmSystem.Properties.Resources.edit;
			this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Location = new System.Drawing.Point(690, 166);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(173, 70);
			this.btnEditar.TabIndex = 8;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
			// 
			// btnSelecionarForn
			// 
			this.btnSelecionarForn.BackColor = System.Drawing.Color.Honeydew;
			this.btnSelecionarForn.BackgroundImage = global::FarmSystem.Properties.Resources.clipboard;
			this.btnSelecionarForn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSelecionarForn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSelecionarForn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSelecionarForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSelecionarForn.Location = new System.Drawing.Point(690, 89);
			this.btnSelecionarForn.Margin = new System.Windows.Forms.Padding(4);
			this.btnSelecionarForn.Name = "btnSelecionarForn";
			this.btnSelecionarForn.Size = new System.Drawing.Size(173, 70);
			this.btnSelecionarForn.TabIndex = 7;
			this.btnSelecionarForn.Text = "Listar";
			this.btnSelecionarForn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnSelecionarForn.UseVisualStyleBackColor = false;
			this.btnSelecionarForn.Click += new System.EventHandler(this.btnSelecionarForn_Click_1);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackColor = System.Drawing.Color.Honeydew;
			this.btnCadastrar.BackgroundImage = global::FarmSystem.Properties.Resources.floppy_disk;
			this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.Location = new System.Drawing.Point(690, 11);
			this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(173, 70);
			this.btnCadastrar.TabIndex = 6;
			this.btnCadastrar.Text = "Gravar";
			this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// epdFornecedor
			// 
			this.epdFornecedor.ContainerControl = this;
			// 
			// frmCadastroFornecedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(880, 405);
			this.Controls.Add(this.txtFoneFornecedor);
			this.Controls.Add(this.txtCnpj);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnSelecionarForn);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.txtEndFornecedor);
			this.Controls.Add(this.txtEmailFornecedor);
			this.Controls.Add(this.txtCidadeFornecedor);
			this.Controls.Add(this.txtNomeFornecedor);
			this.Controls.Add(this.txtCodFornecedor);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmCadastroFornecedor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Fornecedor";
			((System.ComponentModel.ISupportInitialize)(this.epdFornecedor)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnSelecionarForn;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.TextBox txtEndFornecedor;
		private System.Windows.Forms.TextBox txtEmailFornecedor;
		private System.Windows.Forms.TextBox txtCidadeFornecedor;
		private System.Windows.Forms.TextBox txtNomeFornecedor;
		private System.Windows.Forms.TextBox txtCodFornecedor;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txtFoneFornecedor;
        private System.Windows.Forms.ErrorProvider epdFornecedor;
    }
}