using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem.Produtos
{
	public partial class Frmlistaproduto : Form
	{
		public Frmlistaproduto()
		{
			InitializeComponent();
			Produtos_DAO df = new Produtos_DAO();
			dvgprod.DataSource = df.ListaProduto();
		}

		private void Frmlistaproduto_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'farmsystemDB.produtos'. Você pode movê-la ou removê-la conforme necessário.
			this.produtosTableAdapter.Fill(this.farmsystemDB.produtos);

		}

		private void txtbusca_TextChanged(object sender, EventArgs e)
		{
			Produtos_DAO d = new Produtos_DAO();
			dvgprod.DataSource = d.ListaProduto(txtbusca.Text);
		}
	}
}
