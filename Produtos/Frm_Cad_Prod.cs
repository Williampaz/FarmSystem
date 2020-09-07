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
            Produtos_DAO pd = new Produtos_DAO();
            res = pd.getCod() + 1;
            txtcodigo.Text = res + "";
		}

        int res;

        private void Limpar()
        {
            txtcodigofornecedor.Clear();
            txtdiacolheita.Clear();
            txtmesplantio.Clear();
            txtnomeprod.Clear();
            txtvalidade.Clear();
            txtmesdeuso.Clear();
            txttipoprod.Clear();
            txtquantidade.Clear();
            txtprecokguni.Clear();
            txtdescicao.Clear();
            txtcodigo.Clear();

        }

        private Produto getProduto()
        {
            Produto p = new Produto();
            p.codigoforn = Convert.ToInt32(txtcodigofornecedor.Text);
            p.codigo = Convert.ToInt32(txtcodigo.Text);
            p.nome = txtnomeprod.Text;
            p.validade = Convert.ToDateTime(txtvalidade.Text);
            p.mesdeuso = txtmesdeuso.Text;
            p.tipoprod = txttipoprod.Text;
            p.quantidade = Convert.ToInt32(txtquantidade.Text);
            p.precokg_uni = Convert.ToDouble(txtprecokguni.Text);
            p.descricao = txtdescicao.Text;
            p.diacolheita = Convert.ToInt32(txtdiacolheita.Text);
            p.mesdeplantio = Convert.ToDateTime(txtmesplantio.Text);

            return p;
        }

        private void setProduto(Produto p)
        {
            txtcodigo.Text = p.codigo.ToString();

            txtcodigofornecedor.Text = p.codigoforn.ToString();
            txtnomeprod.Text = p.nome.ToString();
            txtvalidade.Text = p.validade.ToString();
            txtmesdeuso.Text = p.mesdeuso.ToString();
            txttipoprod.Text = p.tipoprod.ToString();
            txtquantidade.Text = p.quantidade.ToString();
            txtprecokguni.Text = p.precokg_uni.ToString();             
            txtdescicao.Text = p.descricao.ToString();
            txtdiacolheita.Text = p.diacolheita.ToString();
            txtmesplantio.Text = p.mesdeplantio.ToString();


        }
        Produtos_DAO df = new Produtos_DAO();
        private void btncad_Click(object sender, EventArgs e)
		{
            df.Cadastar(Convert.ToInt32(txtcodigofornecedor.Text), txtnomeprod.Text, Convert.ToInt32(txtquantidade.Text), txttipoprod.Text, txtmesdeuso.Text, Convert.ToDateTime(txtvalidade.Text), Convert.ToDateTime(txtmesplantio.Text), Convert.ToInt32(txtdiacolheita.Text), Convert.ToDouble(txtprecokguni.Text),txtdescicao.Text);
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

        private void txtdescicao_Leave(object sender, EventArgs e)
        {
            epdProdutos.Clear();
            if (txtdescicao.Text.Equals(""))
            {
                epdProdutos.SetError(txtdescicao, "Preencha este campo");
                txtdescicao.Focus();
                return;
            }
        }

        private void txtprecokguni_Leave(object sender, EventArgs e)
        {
            epdProdutos.Clear();
            if (txtprecokguni.Text.Equals(""))
            {
                epdProdutos.SetError(txtprecokguni, "Preencha este campo");
                txtprecokguni.Focus();
                return;
            }
        }

        private void txtquantidade_Leave(object sender, EventArgs e)
        {
            epdProdutos.Clear();
            if (txtquantidade.Text.Equals(""))
            {
                epdProdutos.SetError(txtquantidade, "Preencha este campo");
                txtquantidade.Focus();
                return;
            }
        }

        private void txttipoprod_Leave(object sender, EventArgs e)
        {
            epdProdutos.Clear();
            if (txttipoprod.Text.Equals(""))
            {
                epdProdutos.SetError(txttipoprod, "Preencha este campo");
                txttipoprod.Focus();
                return;
            }
        }

        private void txtmesdeuso_Leave(object sender, EventArgs e)
        {
            epdProdutos.Clear();
            if (txtmesdeuso.Text.Equals(""))
            {
                epdProdutos.SetError(txtmesdeuso, "Preencha este campo");
                txtmesdeuso.Focus();
                return;
            }
        }

        private void txtvalidade_Leave(object sender, EventArgs e)
        {
            epdProdutos.Clear();
            if (!txtvalidade.MaskCompleted)
            {
                epdProdutos.SetError(txtvalidade, "Preencha este campo");
                txtvalidade.Focus();
                return;
            }
        }

        private void txtnomeprod_Leave(object sender, EventArgs e)
        {
            epdProdutos.Clear();
            if (txtnomeprod.Text.Equals(""))
            {
                epdProdutos.SetError(txtnomeprod, "Preencha este campo");
                txtnomeprod.Focus();
                return;
            }
        }

        private void txtmesplantio_Leave(object sender, EventArgs e)
        {
            epdProdutos.Clear();
            if (!txtmesplantio.MaskCompleted)
            {
                epdProdutos.SetError(txtmesplantio, "Preencha este campo");
                txtmesplantio.Focus();
                return;
            }
        }

        private void txtdiacolheita_Leave(object sender, EventArgs e)
        {
            epdProdutos.Clear();
            if (txtdiacolheita.Text.Equals(""))
            {
                epdProdutos.SetError(txtdiacolheita, "Preencha este campo");
                txtdiacolheita.Focus();
                return;
            }
        }
    }
}
