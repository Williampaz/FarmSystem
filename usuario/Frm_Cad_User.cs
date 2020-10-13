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
			txtcidade.Enabled = false;
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
			txtcidade.Enabled = true;

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
			txtcidade.Clear();

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
			if (btn_Cadastrar.Text == "Cadastrar")
			{
				ativa();
				btn_Cadastrar.Text = "Confirmar";
			}
			else
			{
				User_DAO cad = new User_DAO();
				cad.cadastrar(txt_Nome.Text, txt_Rg.Text,txt_CPF.Text, Convert.ToDateTime(txt_DataNascimento.Text),
							  txt_Idade.Text, txt_Email.Text, txt_Senha.Text, txt_Endereco.Text, txtcidade.Text);
				limpar();
				MessageBox.Show("Cadastro realizado com sucesso!!");
				desativa();
				btn_Cadastrar.Text = "Cadastrar";
			}
			
		}
		public void setUser(User user)
		{
			txt_Codigo.Text = user.codigo.ToString();
			txt_CPF.Text = user.cpf;
			txt_DataNascimento.Text = user.nascimento.ToString();
			txt_Email.Text = user.email;
			txt_Endereco.Text = user.endereco;
			txt_Idade.Text = user.idade;
			txt_Nome.Text = user.nome;
			txt_Rg.Text = user.rg;
			txt_Senha.Text = user.senha;
			txtcidade.Text = user.cidade;

		}
		public User GetUser()
		{
			User user = new User();
			
				user.codigo = Convert.ToInt32(txt_Codigo.Text);
				user.nome = txt_Nome.Text;
				user.rg = txt_Rg.Text;
				user.cpf = txt_CPF.Text;
				user.nascimento = Convert.ToDateTime(txt_DataNascimento.Text);
				user.idade = txt_Idade.Text;
				user.email = txt_Email.Text;
				user.senha = txt_Senha.Text;
				user.endereco = txt_Endereco.Text;
			   user.cidade = txtcidade.Text;

			return user;

		}
		private void btn_Editar_Click(object sender, EventArgs e)
		{
			if (btn_Editar.Text == "Editar")
			{
				User_DAO editar = new User_DAO();
				Frm_Sel_User edit = new Frm_Sel_User();
				edit.ShowDialog();
				if (edit.DialogResult == DialogResult.OK)
				{
					setUser(edit.GetUser());
				}
				btn_Editar.Text = "Alterar";
				ativa();
			}
			else
			{
				User_DAO edit = new User_DAO();
				edit.editar(GetUser());
				btn_Editar.Text = "Editar";
				desativa();
			}
		}

        private void txt_Nome_Leave(object sender, EventArgs e)
        {
			epdUsuario.Clear();
			if (txt_Nome.Text.Equals(""))
			{
				epdUsuario.SetError(txt_Nome, "Preencha este campo");
				txt_Nome.Focus();
				return;
			}
		}

        private void txt_Rg_Leave(object sender, EventArgs e)
        {
			epdUsuario.Clear();
			if (txt_Rg.Text.Equals(""))
			{
				epdUsuario.SetError(txt_Rg, "Preencha este campo");
				txt_Rg.Focus();
				return;
			}
		}

        private void txt_DataNascimento_Leave(object sender, EventArgs e)
        {
			epdUsuario.Clear();
			if (txt_Rg.Text.Equals(""))
			{
				epdUsuario.SetError(txt_Rg, "Preencha este campo");
				txt_Rg.Focus();
				return;
			}
		}

        private void txt_Idade_Leave(object sender, EventArgs e)
        {
			epdUsuario.Clear();
			if (txt_Idade.Text.Equals(""))
			{
				epdUsuario.SetError(txt_Idade, "Preencha este campo");
				txt_Idade.Focus();
				return;
			}
		}

        private void txt_Senha_Leave(object sender, EventArgs e)
        {
			epdUsuario.Clear();
			if (txt_Senha.Text.Equals(""))
			{
				epdUsuario.SetError(txt_Senha, "Preencha este campo");
				txt_Senha.Focus();
				return;
			}
		}

        private void txt_Email_Leave(object sender, EventArgs e)
        {
			epdUsuario.Clear();
			if (txt_Email.Text.Equals(""))
			{
				epdUsuario.SetError(txt_Email, "Preencha este campo");
				txt_Email.Focus();
				return;
			}
		}

        private void txt_Endereco_Leave(object sender, EventArgs e)
        {
			epdUsuario.Clear();
			if (txt_Endereco.Text.Equals(""))
			{
				epdUsuario.SetError(txt_Endereco, "Preencha este campo");
				txt_Endereco.Focus();
				return;
			}
		}

        private void txt_CPF_Leave(object sender, EventArgs e)
        {
			epdUsuario.Clear();
			if (!txt_CPF.MaskCompleted)
			{
				epdUsuario.SetError(txt_CPF, "Preencha este campo");
				txt_CPF.Focus();
				return;
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtcidade_Leave(object sender, EventArgs e)
        {

			epdUsuario.Clear();
			if (txtcidade.Text.Equals(""))
			{
				epdUsuario.SetError(txtcidade, "Preencha este campo");
				txtcidade.Focus();
				return;
			}


		}
    }
}