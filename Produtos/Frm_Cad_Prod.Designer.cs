﻿namespace FarmSystem.Produtos
{
	partial class Frm_Cad_Prod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cad_Prod));
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txtprecokguni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiacolheita = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmesdeuso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescicao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnomeprod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigofornecedor = new System.Windows.Forms.TextBox();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtvalidade = new System.Windows.Forms.MaskedTextBox();
            this.txtmesplantio = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsel = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.epdProdutos = new System.Windows.Forms.ErrorProvider(this.components);
            this.txttipoprod = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_Sel_Forn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epdProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackgroundImage = global::FarmSystem.Properties.Resources.clean;
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(735, 335);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(173, 70);
            this.btnlimpar.TabIndex = 15;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // txtprecokguni
            // 
            this.txtprecokguni.Location = new System.Drawing.Point(389, 238);
            this.txtprecokguni.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecokguni.Name = "txtprecokguni";
            this.txtprecokguni.Size = new System.Drawing.Size(310, 22);
            this.txtprecokguni.TabIndex = 9;
            this.txtprecokguni.Leave += new System.EventHandler(this.txtprecokguni_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Preço kg (Unidade):";
            // 
            // txtdiacolheita
            // 
            this.txtdiacolheita.Location = new System.Drawing.Point(416, 139);
            this.txtdiacolheita.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiacolheita.Name = "txtdiacolheita";
            this.txtdiacolheita.Size = new System.Drawing.Size(168, 22);
            this.txtdiacolheita.TabIndex = 2;
            this.txtdiacolheita.Leave += new System.EventHandler(this.txtdiacolheita_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Dia da Colheita:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Validade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(588, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Mês de Plantio:";
            // 
            // txtmesdeuso
            // 
            this.txtmesdeuso.Location = new System.Drawing.Point(549, 192);
            this.txtmesdeuso.Margin = new System.Windows.Forms.Padding(4);
            this.txtmesdeuso.MaxLength = 15;
            this.txtmesdeuso.Name = "txtmesdeuso";
            this.txtmesdeuso.Size = new System.Drawing.Size(150, 22);
            this.txtmesdeuso.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(546, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mês de Uso:";
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(13, 238);
            this.txtquantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantidade.MaxLength = 10;
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(368, 22);
            this.txtquantidade.TabIndex = 8;
            this.txtquantidade.Leave += new System.EventHandler(this.txtquantidade_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Quantidade:";
            // 
            // txtdescicao
            // 
            this.txtdescicao.Location = new System.Drawing.Point(13, 288);
            this.txtdescicao.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescicao.MaxLength = 500;
            this.txtdescicao.Multiline = true;
            this.txtdescicao.Name = "txtdescicao";
            this.txtdescicao.Size = new System.Drawing.Size(686, 117);
            this.txtdescicao.TabIndex = 10;
            this.txtdescicao.Leave += new System.EventHandler(this.txtdescicao_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 268);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Descrição:";
            // 
            // txtnomeprod
            // 
            this.txtnomeprod.Location = new System.Drawing.Point(13, 192);
            this.txtnomeprod.Margin = new System.Windows.Forms.Padding(4);
            this.txtnomeprod.MaxLength = 80;
            this.txtnomeprod.Name = "txtnomeprod";
            this.txtnomeprod.Size = new System.Drawing.Size(368, 22);
            this.txtnomeprod.TabIndex = 4;
            this.txtnomeprod.Leave += new System.EventHandler(this.txtnomeprod_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome do Produto:";
            // 
            // txtcodigofornecedor
            // 
            this.txtcodigofornecedor.Location = new System.Drawing.Point(13, 139);
            this.txtcodigofornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigofornecedor.Name = "txtcodigofornecedor";
            this.txtcodigofornecedor.Size = new System.Drawing.Size(115, 22);
            this.txtcodigofornecedor.TabIndex = 1;
            this.txtcodigofornecedor.TextChanged += new System.EventHandler(this.txtcodigofornecedor_TextChanged);
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.Location = new System.Drawing.Point(173, 120);
            this.lblCódigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(141, 16);
            this.lblCódigo.TabIndex = 20;
            this.lblCódigo.Text = "Nome Fornecedor:";
            this.lblCódigo.Click += new System.EventHandler(this.lblCódigo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Código Fornecedor:";
            // 
            // txtvalidade
            // 
            this.txtvalidade.Location = new System.Drawing.Point(392, 192);
            this.txtvalidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtvalidade.Mask = "00/00/0000";
            this.txtvalidade.Name = "txtvalidade";
            this.txtvalidade.Size = new System.Drawing.Size(146, 22);
            this.txtvalidade.TabIndex = 5;
            this.txtvalidade.ValidatingType = typeof(System.DateTime);
            this.txtvalidade.Leave += new System.EventHandler(this.txtvalidade_Leave);
            // 
            // txtmesplantio
            // 
            this.txtmesplantio.Location = new System.Drawing.Point(591, 139);
            this.txtmesplantio.Margin = new System.Windows.Forms.Padding(4);
            this.txtmesplantio.Mask = "00/00/0000";
            this.txtmesplantio.Name = "txtmesplantio";
            this.txtmesplantio.Size = new System.Drawing.Size(108, 22);
            this.txtmesplantio.TabIndex = 3;
            this.txtmesplantio.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "Código:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(13, 93);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(176, 22);
            this.txtcodigo.TabIndex = 41;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackgroundImage = global::FarmSystem.Properties.Resources.delete;
            this.btnexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(735, 257);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(173, 70);
            this.btnexcluir.TabIndex = 14;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackgroundImage = global::FarmSystem.Properties.Resources.edit;
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(735, 178);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(173, 70);
            this.btnedit.TabIndex = 13;
            this.btnedit.Text = "Editar";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsel
            // 
            this.btnsel.BackgroundImage = global::FarmSystem.Properties.Resources.clipboard;
            this.btnsel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsel.Location = new System.Drawing.Point(735, 99);
            this.btnsel.Margin = new System.Windows.Forms.Padding(4);
            this.btnsel.Name = "btnsel";
            this.btnsel.Size = new System.Drawing.Size(173, 70);
            this.btnsel.TabIndex = 12;
            this.btnsel.Text = "Listar";
            this.btnsel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnsel.UseVisualStyleBackColor = true;
            this.btnsel.Click += new System.EventHandler(this.btnsel_Click);
            // 
            // btncad
            // 
            this.btncad.BackgroundImage = global::FarmSystem.Properties.Resources.floppy_disk;
            this.btncad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncad.Location = new System.Drawing.Point(735, 20);
            this.btncad.Margin = new System.Windows.Forms.Padding(4);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(173, 70);
            this.btncad.TabIndex = 11;
            this.btncad.Text = "Gravar";
            this.btncad.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btncad.UseVisualStyleBackColor = true;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // epdProdutos
            // 
            this.epdProdutos.ContainerControl = this;
            // 
            // txttipoprod
            // 
            this.txttipoprod.FormattingEnabled = true;
            this.txttipoprod.Items.AddRange(new object[] {
            "Semente",
            "Outros Insumos"});
            this.txttipoprod.Location = new System.Drawing.Point(13, 37);
            this.txttipoprod.Name = "txttipoprod";
            this.txttipoprod.Size = new System.Drawing.Size(331, 24);
            this.txttipoprod.TabIndex = 43;
            this.txttipoprod.SelectedIndexChanged += new System.EventHandler(this.txttipoprod_SelectedIndexChanged);
            this.txttipoprod.TextChanged += new System.EventHandler(this.cmbtipo_TextChanged);
            this.txttipoprod.Leave += new System.EventHandler(this.cmbtipo_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 16);
            this.label12.TabIndex = 44;
            this.label12.Text = "Tipo de Cadastro:";
            // 
            // cmb_Sel_Forn
            // 
            this.cmb_Sel_Forn.Location = new System.Drawing.Point(172, 139);
            this.cmb_Sel_Forn.Name = "cmb_Sel_Forn";
            this.cmb_Sel_Forn.Size = new System.Drawing.Size(237, 22);
            this.cmb_Sel_Forn.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Cad_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(923, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_Sel_Forn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txttipoprod);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtmesplantio);
            this.Controls.Add(this.txtvalidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsel);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtprecokguni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdiacolheita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmesdeuso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdescicao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtnomeprod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodigofornecedor);
            this.Controls.Add(this.lblCódigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_Cad_Prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Frm_Cad_Prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epdProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnlimpar;
		private System.Windows.Forms.Button btnexcluir;
		private System.Windows.Forms.Button btnedit;
		private System.Windows.Forms.Button btnsel;
		private System.Windows.Forms.Button btncad;
		private System.Windows.Forms.TextBox txtprecokguni;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtdiacolheita;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtmesdeuso;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtquantidade;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtdescicao;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtnomeprod;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtcodigofornecedor;
		private System.Windows.Forms.Label lblCódigo;
		private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtvalidade;
        private System.Windows.Forms.MaskedTextBox txtmesplantio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.ErrorProvider epdProdutos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txttipoprod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cmb_Sel_Forn;
    }
}