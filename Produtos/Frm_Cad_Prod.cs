using FarmSystem.usuario;
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
	public partial class Frm_Cad_Prod : Form
	{
		public Frm_Cad_Prod()
		{
			InitializeComponent();
		}
        private void Limpar()
        {
            txtcodfornecedor.Clear();
            txtdiacolheita.Clear();
            txtmescolheita.Clear();
            txtnomeprod.Clear();
            txtvalidade.Clear();
            txtmesdeuso.Clear();
            txttipoprod.Clear();
            txtquantidade.Clear();
            txtprecokguni.Clear();
            txtdescicao.Clear();
        }

        private Produto getProduto()
        {
            Produto p = new Produto();
            p.codigo = Convert.ToInt32(txtcodfornecedor.Text);
            p.nome = txtnomeprod.Text;
            p.validade = Convert.ToDateTime(txtvalidade.Text);
            p.mesdeuso = txtmesdeuso.Text;
            p.tipoprod = txttipoprod.Text;
            p.quantidade = Convert.ToInt32(txtquantidade.Text);
            p.preçokg_uni= Convert.ToDouble(txtprecokguni.Text);
            p.descricao = txtdescicao.Text;
            return p;
        }

        private void setProduto(Produto p)
        {
            txtcodfornecedor.Text = p.codigo.ToString();
            txtnomeprod.Text = p.nome;
            txtvalidade.Text = p.validade.ToString();
            txtmesdeuso.Text = p.mesdeuso;
            txttipoprod.Text = p.tipoprod;
            txtquantidade.Text = p.quantidade.ToString();
            txtquantidade.Text = p.quantidade.ToString();
            txtdescicao.Text = p.descricao.ToString();
        }
        Produtos_DAO df = new Produtos_DAO();
        private void btncad_Click(object sender, EventArgs e)
		{
            
            df.Cadastar(getProduto());
            MessageBox.Show("Produto cadastrado com sucesso !", "Cadastro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

		private void btnlimpar_Click(object sender, EventArgs e)
		{
            Limpar();
        }

		private void btnexcluir_Click(object sender, EventArgs e)
		{
            if (MessageBox.Show("Deseja excluir este fornecedor ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                df.Excluir(getProduto());
                Limpar();
            }
        }

		private void btnedit_Click(object sender, EventArgs e)
		{
            df.Editar(getProduto());
            MessageBox.Show("Dados alterados", "Edição concluida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Limpar();
        }

		private void btnsel_Click(object sender, EventArgs e)
		{
            Frm_Cad_Prod sel = new Frm_Cad_Prod();
          
            sel.ShowDialog();
            if (sel.DialogResult == DialogResult.OK)
            {
                setProduto(sel.getProduto());
            }
        }
	}
}
