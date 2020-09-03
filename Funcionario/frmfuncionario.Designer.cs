namespace FarmSystem.Funcionario
{
    partial class frmfuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfuncionario));
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskdtanasc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mskdtaadm = new System.Windows.Forms.MaskedTextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnlistar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(11, 28);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(179, 20);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(10, 96);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(665, 20);
            this.txtnome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // mskdtanasc
            // 
            this.mskdtanasc.Location = new System.Drawing.Point(273, 138);
            this.mskdtanasc.Mask = "00/00/0000";
            this.mskdtanasc.Name = "mskdtanasc";
            this.mskdtanasc.Size = new System.Drawing.Size(186, 20);
            this.mskdtanasc.TabIndex = 3;
            this.mskdtanasc.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de nascimento:";
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(14, 138);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(253, 20);
            this.txtidade.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Idade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone:";
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(465, 138);
            this.msktel.Mask = "(99) 00000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(210, 20);
            this.msktel.TabIndex = 4;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(11, 181);
            this.txtendereco.Multiline = true;
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(664, 81);
            this.txtendereco.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data de admissão:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // mskdtaadm
            // 
            this.mskdtaadm.Location = new System.Drawing.Point(14, 281);
            this.mskdtaadm.Mask = "00/00/0000";
            this.mskdtaadm.Name = "mskdtaadm";
            this.mskdtaadm.Size = new System.Drawing.Size(179, 20);
            this.mskdtaadm.TabIndex = 6;
            this.mskdtaadm.ValidatingType = typeof(System.DateTime);
            this.mskdtaadm.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(199, 281);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(295, 20);
            this.txtcargo.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(199, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cargo:";
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(500, 281);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(175, 20);
            this.txtsalario.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(500, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Salario:";
            // 
            // btnlistar
            // 
            this.btnlistar.BackgroundImage = global::FarmSystem.Properties.Resources.clipboard;
            this.btnlistar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlistar.Location = new System.Drawing.Point(692, 207);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(131, 59);
            this.btnlistar.TabIndex = 12;
            this.btnlistar.Text = "Listar";
            this.btnlistar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackgroundImage = global::FarmSystem.Properties.Resources.delete;
            this.btnexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexcluir.Location = new System.Drawing.Point(692, 142);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(131, 59);
            this.btnexcluir.TabIndex = 11;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackgroundImage = global::FarmSystem.Properties.Resources.edit;
            this.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btneditar.Location = new System.Drawing.Point(692, 77);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(131, 59);
            this.btneditar.TabIndex = 10;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btngravar
            // 
            this.btngravar.BackgroundImage = global::FarmSystem.Properties.Resources.floppy_disk;
            this.btngravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btngravar.Location = new System.Drawing.Point(692, 12);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(131, 59);
            this.btngravar.TabIndex = 9;
            this.btngravar.Text = "Gravar";
            this.btngravar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackgroundImage = global::FarmSystem.Properties.Resources.clean;
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlimpar.Location = new System.Drawing.Point(692, 272);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(131, 59);
            this.btnlimpar.TabIndex = 17;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // frmfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 336);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mskdtaadm);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msktel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskdtanasc);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmfuncionario";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.frmfuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskdtanasc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskdtaadm;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.Button btnlimpar;
    }
}