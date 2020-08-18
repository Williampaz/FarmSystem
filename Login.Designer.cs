namespace FarmSystem
{
	partial class Login
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Usuario = new System.Windows.Forms.TextBox();
			this.txt_Senha = new System.Windows.Forms.TextBox();
			this.btn_Entrar = new System.Windows.Forms.Button();
			this.btn_Sair = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 70);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuário";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 126);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Senha";
			// 
			// txt_Usuario
			// 
			this.txt_Usuario.Location = new System.Drawing.Point(120, 62);
			this.txt_Usuario.Margin = new System.Windows.Forms.Padding(6);
			this.txt_Usuario.Name = "txt_Usuario";
			this.txt_Usuario.Size = new System.Drawing.Size(180, 29);
			this.txt_Usuario.TabIndex = 2;
			// 
			// txt_Senha
			// 
			this.txt_Senha.Location = new System.Drawing.Point(120, 121);
			this.txt_Senha.Margin = new System.Windows.Forms.Padding(6);
			this.txt_Senha.Name = "txt_Senha";
			this.txt_Senha.PasswordChar = '*';
			this.txt_Senha.Size = new System.Drawing.Size(180, 29);
			this.txt_Senha.TabIndex = 3;
			// 
			// btn_Entrar
			// 
			this.btn_Entrar.Location = new System.Drawing.Point(323, 58);
			this.btn_Entrar.Margin = new System.Windows.Forms.Padding(6);
			this.btn_Entrar.Name = "btn_Entrar";
			this.btn_Entrar.Size = new System.Drawing.Size(138, 42);
			this.btn_Entrar.TabIndex = 4;
			this.btn_Entrar.Text = "Entrar";
			this.btn_Entrar.UseVisualStyleBackColor = true;
			this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
			// 
			// btn_Sair
			// 
			this.btn_Sair.Location = new System.Drawing.Point(323, 114);
			this.btn_Sair.Margin = new System.Windows.Forms.Padding(6);
			this.btn_Sair.Name = "btn_Sair";
			this.btn_Sair.Size = new System.Drawing.Size(138, 42);
			this.btn_Sair.TabIndex = 5;
			this.btn_Sair.Text = "Sair";
			this.btn_Sair.UseVisualStyleBackColor = true;
			this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 199);
			this.Controls.Add(this.btn_Sair);
			this.Controls.Add(this.btn_Entrar);
			this.Controls.Add(this.txt_Senha);
			this.Controls.Add(this.txt_Usuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Acesso Do Usuário";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_Usuario;
		private System.Windows.Forms.TextBox txt_Senha;
		private System.Windows.Forms.Button btn_Entrar;
		private System.Windows.Forms.Button btn_Sair;
	}
}

