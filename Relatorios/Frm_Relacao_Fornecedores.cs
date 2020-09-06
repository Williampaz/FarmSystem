using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem.Relatorios
{
	public partial class Frm_Relacao_Fornecedores : Form
	{
		public Frm_Relacao_Fornecedores()
		{
			InitializeComponent();
		}

		private void Frm_Relacao_Fornecedores_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'farmsystemDB.fornecedor'. Você pode movê-la ou removê-la conforme necessário.
			this.fornecedorTableAdapter.Fill(this.farmsystemDB.fornecedor);

			this.Rp_Fornecedores.RefreshReport();
		}
	}
}
