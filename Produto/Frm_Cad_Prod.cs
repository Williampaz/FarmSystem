using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem
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
            p.validade = txtvalidade.Text;
            p.mesdeuso = txtmesdeuso.Text;
            p.tipoprod = txttipoprod.Text;
            p.quantidade = txtquantidade.Text;
            p.precokguni = txtprecokguni.Text;
            p.descricao = txtdescicao.Text;
            return p;
        }

        private void setProduto(Produto p)
        {
            txtcodfornecedor.Text = p.codigo.ToString();
            txtnomeprod.Text = p.nome;
            txtvalidade.Text = p.validade;
            txtmesdeuso.Text = p.mesdeuso;
            txttipoprod.Text = p.tipoprod;
            txtquantidade.Text = p.quantidade;
            txtquantidade.Text = p.quantidade;
            txtdescicao.Text = p.descicao;
        }


        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void btncad_Click(object sender, EventArgs e)
        {
            DAOproduto df = new DAOproduto();
            df.Cadastar(getProduto());
            MessageBox.Show("Produto cadastrado com sucesso !", "Cadastro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }
        
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            DAOproduto df = new DAOproduto();
            df.Editar(getProduto());
            MessageBox.Show("Dados alterados", "Edição concluida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Limpar();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir este fornecedor ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOproduto df = new DAOproduto();
                df.Excluir(getProduto());
                Limpar();
            }
        }

        private void btnsel_Click(object sender, EventArgs e)
        {
         
        }
    }
}
