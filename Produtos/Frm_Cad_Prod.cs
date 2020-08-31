using FarmSystem.Fornecedor;
using FarmSystem.usuario;
using Npgsql;
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
            txtcodigofornecedor.Clear();
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
            p.codigo = Convert.ToInt32(txtcodigofornecedor.Text);
            p.nome = txtnomeprod.Text;
            p.validade = Convert.ToDateTime(txtvalidade.Text);
            p.mesdeuso = txtmesdeuso.Text;
            p.tipoprod = txttipoprod.Text;
            p.quantidade = Convert.ToInt32(txtquantidade.Text);
            p.precokg_uni = Convert.ToInt32(txtprecokguni.Text);
            p.descricao = txtdescicao.Text;
            return p;
        }

        private void setProduto(Produto p)
        {
            txtcodigofornecedor.Text = p.codigo.ToString();
            txtnomeprod.Text = p.nome;
            txtvalidade.Text = p.validade.ToString();
            txtmesdeuso.Text = p.mesdeuso;
            txttipoprod.Text = p.tipoprod;
            txtquantidade.Text = p.quantidade.ToString();
            txtprecokguni.Text = p.precokg_uni.ToString();             
            txtdescicao.Text = p.descricao.ToString();
        }
        Produtos_DAO df = new Produtos_DAO();
        private void btncad_Click(object sender, EventArgs e)
		{
            df.Cadastar(Convert.ToInt32(txtcodigofornecedor.Text), txtnomeprod.Text, Convert.ToInt32(txtquantidade.Text), txttipoprod.Text, txtmesdeuso.Text, Convert.ToDateTime(txtvalidade.Text), txtmescolheita.Text, Convert.ToInt32(txtdiacolheita.Text), Convert.ToDouble(txtprecokguni.Text),txtdescicao.Text);
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
            Frmlistaproduto sel = new Frmlistaproduto();
          
            sel.ShowDialog();

            if (sel.DialogResult == DialogResult.OK)
            {
                setProduto(sel.getProduto());
            }
        }
        private void PreencherCombo()
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select * from farmsystem.fornecedor order by nome ASC");

            try
            {
                query.Connection = conn.entrar();
                NpgsqlDataReader fornecedor = query.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(fornecedor);
                cmb_Sel_Forn.DisplayMember = "nome";
                cmb_Sel_Forn.ValueMember = "codigo";
                cmb_Sel_Forn.DataSource = dt;
                conn.sair();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
            finally
            {
                conn.sair();
            }
        }
        private void cmb_Sel_Forn_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_Sel_Forn.SelectedIndex != -1)
            {

                DataRowView drw = ((DataRowView)cmb_Sel_Forn.SelectedItem);
                txtcodigofornecedor.Text = drw["codigo"].ToString();
            }
            else
            {
                txtcodigofornecedor.Text = "";
            }
        }
        private void Frm_Cad_Prod_Load(object sender, EventArgs e)
		{
            
        }

		private void cmb_Sel_Forn_Click(object sender, EventArgs e)
		{
            PreencherCombo();
        }
	}
}
