using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem.Fornecedor
{
	public partial class frmCadastroFornecedor : Form
	{
		public frmCadastroFornecedor()
		{
			InitializeComponent();
		}

        private void Limpar()
        {
            txtCodFornecedor.Clear();
            txtNomeFornecedor.Clear();
            txtEndFornecedor.Clear();
            txtCidadeFornecedor.Clear();
            txtCnpj.Clear();
            txtFoneFornecedor.Clear();
            txtEmailFornecedor.Clear();
        }

        private Fornecedor getFornecedor()
        {
            Fornecedor f = new Fornecedor();
            f.nome = txtNomeFornecedor.Text;
            f.telefone = txtFoneFornecedor.Text;
            f.endereco = txtEndFornecedor.Text;
            f.cnpj = txtCnpj.Text;
            f.cidade = txtCidadeFornecedor.Text;
            f.email = txtEmailFornecedor.Text;
            return f;
        }

        private void setFornecedor(Fornecedor f)
        {
            txtCodFornecedor.Text = f.codigo.ToString();
            txtNomeFornecedor.Text = f.nome;
            txtEndFornecedor.Text = f.endereco;
            txtCidadeFornecedor.Text = f.cidade;
            txtCnpj.Text = f.cnpj;
            txtFoneFornecedor.Text = f.telefone;
            txtEmailFornecedor.Text = f.email;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DAOfornecedor df = new DAOfornecedor();
            df.Cadastar(getFornecedor());
            MessageBox.Show("Fornecedor cadastrado com sucesso !", "Cadastro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }


        
		private void btnSelecionarForn_Click_1(object sender, EventArgs e)
		{
            frmListaFornecedor lf = new frmListaFornecedor();
            lf.ShowDialog();
            if (lf.DialogResult == DialogResult.OK)
            {
                setFornecedor(lf.GetFornecedor());
            }
        }

		private void btnEditar_Click_1(object sender, EventArgs e)
		{
            DAOfornecedor df = new DAOfornecedor();
            df.Editar(getFornecedor());
            MessageBox.Show("Dados alterados", "Edição concluida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Limpar();
        }

		private void btnExcluir_Click(object sender, EventArgs e)
		{
            if (MessageBox.Show("Deseja excluir este fornecedor ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOfornecedor df = new DAOfornecedor();
                df.Excluir(Convert.ToInt32(txtCodFornecedor.Text));
                Limpar();
            }
        }

		private void btnLimpar_Click(object sender, EventArgs e)
		{
            Limpar();
        }

        private void txtCodFornecedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
