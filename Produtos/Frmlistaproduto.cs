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


		public Produto getProduto()
        {

			Produto p = new Produto();
			p.codigo = Convert.ToInt32(dvgprod.CurrentRow.Cells[0].Value);
			p.codigoforn = Convert.ToInt32(dvgprod.CurrentRow.Cells[1].Value);
			p.tipoprod = dvgprod.CurrentRow.Cells[2].ToString();
			p.nome = dvgprod.CurrentRow.Cells[3].ToString();
			p.quantidade = Convert.ToInt32(dvgprod.CurrentRow.Cells[4].Value);
			p.mesdeuso = dvgprod.CurrentRow.Cells[5].ToString();
			p.validade = Convert.ToDateTime(dvgprod.CurrentRow.Cells[6].Value);
			p.mesdeplantio = Convert.ToDateTime(dvgprod.CurrentRow.Cells[7].Value);
			p.diacolheita = Convert.ToInt32(dvgprod.CurrentRow.Cells[8].Value);
			p.precokg_uni = Convert.ToInt32(dvgprod.CurrentRow.Cells[9].Value);

			p.descricao = dvgprod.CurrentRow.Cells[10].ToString();
			return p;

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
