using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem.usuario
{
	public partial class Frm_Cad_User : Form
	{
		public Frm_Cad_User()
		{
			InitializeComponent();
			txt_Codigo.Enabled = false;
			desativa();
		}
		public void desativa()
		{
			txt_CPF.Enabled = false;
			txt_DataNascimento.Enabled = false;
			txt_Email.Enabled = false;
			txt_Endereco.Enabled = false;
			txt_Idade.Enabled = false;
			txt_Nome.Enabled = false;
			txt_Rg.Enabled = false;
			txt_Senha.Enabled = false;
		}
		public void ativa()
		{
			txt_CPF.Enabled = true;
			txt_DataNascimento.Enabled = true;
			txt_Email.Enabled = true;
			txt_Endereco.Enabled = true;
			txt_Idade.Enabled = true;
			txt_Nome.Enabled = true;
			txt_Rg.Enabled = true;
			txt_Senha.Enabled = true;
		}
		public void limpar()
		{
			txt_Codigo.Clear();
			txt_CPF.Clear();
			txt_DataNascimento.Clear();
			txt_Email.Clear();
			txt_Endereco.Clear();
			txt_Idade.Clear();
			txt_Nome.Clear();
			txt_Rg.Clear();
			txt_Senha.Clear();
		}
		private void btn_Cancelar_Click(object sender, EventArgs e)
		{
			if (btn_Cadastrar.Text == "Cadastrar")
			{
				this.Close();
			}
			else
			{
				btn_Cadastrar.Text = "Cadastrar";
				desativa();
			}
		}

		private void btn_Limpar_Click(object sender, EventArgs e)
		{
			limpar();
		}

		private void btn_Cadastrar_Click(object sender, EventArgs e)
		{
			"teste"
			if (btn_Cadastrar.Text == "Cadastrar")
			{
				ativa();
				btn_Cadastrar.Text = "Confirmar";
			}
			else
			{
				User_DAO cad = new User_DAO();
				cad.cadastrar(txt_Nome.Text, txt_Rg.Text, txt_Codigo.Text, Convert.ToDateTime(txt_DataNascimento.Text),
							  txt_Idade.Text, txt_Email.Text, txt_Senha.Text, txt_Endereco.Text);
				limpar();
				MessageBox.Show("Cadastro realizado com sucesso!!");
				desativa();
				btn_Cadastrar.Text = "Cadastrar";
			}
			
		}
	}
}