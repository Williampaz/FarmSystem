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
using FarmSystem.Plantação;
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


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

		private void btnplantacao_Click(object sender, EventArgs e)
		{
			new plantacao().ShowDialog();
		}

		private void acõesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new acoes().ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{

			{
				// Find your Account Sid and Token at twilio.com/console
				// DANGER! This is insecure. See http://twil.io/secure
				const string accountSid = "ACcac9d2c8905ff49a25a5482fac9ab034";
				const string authToken = "4f370b37457c4a104914519238065605";

				TwilioClient.Init(accountSid, authToken);

				var message = MessageResource.Create(
					body: "Teste de mensagem do sistema FarmSystem",
					from: new Twilio.Types.PhoneNumber("+19285698227"),
					to: new Twilio.Types.PhoneNumber("+5514988162072")
				);
				
				Console.WriteLine(message.Sid);
			}
		}
	}
}
