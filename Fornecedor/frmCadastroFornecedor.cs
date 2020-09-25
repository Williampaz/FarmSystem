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
            DAOfornecedor df = new DAOfornecedor();
            res = df.getCod() + 1;
            txtCodFornecedor.Text = res + "";
            txtNomeFornecedor.Focus();
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
		}

        int res;

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

        private void LimparBtn()
        {
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
            f.codigo = Convert.ToInt32(txtCodFornecedor.Text);
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
            try
            {
                DAOfornecedor df = new DAOfornecedor();
                df.Cadastar(getFornecedor());
                MessageBox.Show("Fornecedor cadastrado com sucesso !", "Cadastro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                res = df.getCod() + 1;
                txtCodFornecedor.Text = res + "";
            } catch (Exception )
            {
                MessageBox.Show("Não foi possível realizar o cadastro, tente novamente", "Verifique se os dados estão corretos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
		private void btnSelecionarForn_Click_1(object sender, EventArgs e)
		{
            try
            {
                frmListaFornecedor lf = new frmListaFornecedor();
                lf.ShowDialog();
                if (lf.DialogResult == DialogResult.OK)
                {
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnCadastrar.Enabled = false;
                    setFornecedor(lf.GetFornecedor());
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void btnEditar_Click_1(object sender, EventArgs e)
		{
            try
            {
                DAOfornecedor df = new DAOfornecedor();
                df.Editar(getFornecedor());
                MessageBox.Show("Dados alterados", "Edição concluida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpar();
                btnCadastrar.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                res = df.getCod() + 1;
                txtCodFornecedor.Text = res + "";
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível realizar a edição, tente novamente", "Erro na edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void btnExcluir_Click(object sender, EventArgs e)
		{
            try
            {
                if (MessageBox.Show("Deseja excluir este fornecedor ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAOfornecedor df = new DAOfornecedor();
                    df.Excluir(Convert.ToInt32(txtCodFornecedor.Text));
                    Limpar();
                    btnCadastrar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    res = df.getCod() + 1;
                    txtCodFornecedor.Text = res + "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível realizar a exclusão, tente novamente", "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void btnLimpar_Click(object sender, EventArgs e)
		{
            LimparBtn();
        }

        private void txtNomeFornecedor_Leave(object sender, EventArgs e)
        {
            epdFornecedor.Clear();
            if(txtNomeFornecedor.Text.Equals(""))
            {
                epdFornecedor.SetError(txtNomeFornecedor, "Preencha este campo");
                txtNomeFornecedor.Focus();
                return;
            }
        }

        private void txtEndFornecedor_Leave(object sender, EventArgs e)
        {
            epdFornecedor.Clear();
            if (txtEndFornecedor.Text.Equals(""))
            {
                epdFornecedor.SetError(txtEndFornecedor, "Preencha este campo");
                txtEndFornecedor.Focus();
                return;
            }
        }

        private void txtCidadeFornecedor_Leave(object sender, EventArgs e)
        {
            epdFornecedor.Clear();
            if (txtCidadeFornecedor.Text.Equals(""))
            {
                epdFornecedor.SetError(txtCidadeFornecedor, "Preencha este campo");
                txtCidadeFornecedor.Focus();
                return;
            }
        }

        private void txtEmailFornecedor_Leave(object sender, EventArgs e)
        {
            epdFornecedor.Clear();
            if (txtEmailFornecedor.Text.Equals(""))
            {
                epdFornecedor.SetError(txtEmailFornecedor, "Preencha este campo");
                txtEmailFornecedor.Focus();
                return;
            }
        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            epdFornecedor.Clear();
            if (!txtCnpj.MaskCompleted)
            {
                epdFornecedor.SetError(txtCnpj, "Preencha este campo");
                txtCnpj.Focus();
                return;
            }
        }

        private void txtFoneFornecedor_Leave(object sender, EventArgs e)
        {
            epdFornecedor.Clear();
            if (!txtFoneFornecedor.MaskCompleted)
            {
                epdFornecedor.SetError(txtFoneFornecedor, "Preencha este campo");
                txtFoneFornecedor.Focus();
                return;
            }
        }
    }
}
