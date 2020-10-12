﻿using FarmSystem.Fornecedor;
using FarmSystem.Funcionario;
using FarmSystem.Plantação;
using FarmSystem.Produtos;
using FarmSystem.Relatorios;
using FarmSystem.usuario;
using System;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using FarmSystem.Previsão_do_tempo;

namespace FarmSystem.Principal
{
	public partial class Frm_Inicial : Form
	{
		public Frm_Inicial()
		{
			InitializeComponent();
			Slidepanel.Height = button1.Height;
			Slidepanel.Top = button1.Top;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Slidepanel.Height = button1.Height;
			Slidepanel.Top = button1.Top;
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
				const string authToken = "4ba42b0c1c580d3d222c7d73bee97380";

				TwilioClient.Init(accountSid, authToken);

				var message = MessageResource.Create(
					body: "Teste de mensagem do sistema FarmSystem",
					from: new Twilio.Types.PhoneNumber("+19285698227"),
					to: new Twilio.Types.PhoneNumber("+5514988162072")
				);

				Console.WriteLine(message.Sid);
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{

			Slidepanel.Height = button6.Height;
			Slidepanel.Top = button6.Top;
			new frmCadastroFornecedor().ShowDialog();
		}

		private void button7_Click(object sender, EventArgs e)
		{

			Slidepanel.Height = button7.Height;
			Slidepanel.Top = button7.Top;
			new frmfuncionario().ShowDialog();

		}

		private void button8_Click(object sender, EventArgs e)
		{
			Slidepanel.Height = button8.Height;
			Slidepanel.Top = button8.Top;
			new Frm_Cad_Prod().ShowDialog();

		}

		private void button9_Click(object sender, EventArgs e)
		{

			Slidepanel.Height = button9.Height;
			Slidepanel.Top = button9.Top;
			new plantacao().ShowDialog();

		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
<<<<<<< HEAD
	}
=======

        private void button2_Click_1(object sender, EventArgs e)
        {
			Slidepanel.Height = button2.Height;
			Slidepanel.Top = button2.Top;
			new previsao().ShowDialog();
        }
    }
>>>>>>> ae66c0eab47d3ba4a74c2b6732a4bb2e5223b757
}
