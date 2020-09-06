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
	public partial class Frm_Relacao_de_Funcionarios : Form
	{
		public Frm_Relacao_de_Funcionarios()
		{
			InitializeComponent();
		}

		private void Frm_Relacao_de_Funcionarios_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'farmsystemDB.funcionario'. Você pode movê-la ou removê-la conforme necessário.
			this.funcionarioTableAdapter.Fill(this.farmsystemDB.funcionario);

			this.Rp_Funcionarios.RefreshReport();
		}
	}
}
