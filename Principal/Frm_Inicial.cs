using FarmSystem.usuario;
using FarmSystem.Fornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmSystem.Funcionario;
using FarmSystem.Produtos;
using FarmSystem.Relatorios;

namespace FarmSystem.Principal
{
	public partial class Frm_Inicial : Form
	{
		public Frm_Inicial()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new Frm_Cad_User().ShowDialog();  
		}

		private void button2_Click(object sender, EventArgs e)
		{
			new frmCadastroFornecedor().ShowDialog();
		}

        private void button3_Click(object sender, EventArgs e)
        {
			new frmfuncionario().ShowDialog();

        }

        private void Frm_Inicial_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
			new Frm_Cad_Prod().ShowDialog();

        }

		private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Frm_Cad_User().ShowDialog();
		}

		private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frmfuncionario().ShowDialog();
		}

		private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frmCadastroFornecedor().ShowDialog();
		}

		private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Frm_Cad_Prod().ShowDialog();
		}

		private void relatoriosPessoalToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void relaçãoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Frm_Relacao_User().ShowDialog();
		}

		private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Frm_Relacao_de_Funcionarios().ShowDialog();
		}

		private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			new Frm_Relacao_Fornecedores().ShowDialog();
		}

		private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			new Frm_Relacao_Produtos().ShowDialog();
		}
	}
}
