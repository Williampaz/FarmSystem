using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmSystem.Funcionario;
using FarmSystem.Produtos;

namespace FarmSystem.Plantação
{
    public partial class acoes : Form
    {
        public acoes()
        {
            InitializeComponent();
            DAOacao da = new DAOacao();
            res = da.getCod() + 1;
            txtcodigo.Text = res + "";
        }

        int res;

        private void acoes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'postgresDataSet2.acoes'. Você pode movê-la ou removê-la conforme necessário.
            // this.acoesTableAdapter.Fill(this.postgresDataSet2.acoes);
            Atualizar();
        }

        private void Atualizar()
        {
            DAOacao da = new DAOacao();
            dgvacoes.DataSource = da.ListaAcoes();

        }

        private void setPlantacao(objplantacao p)
        {
            txtplantacao.Text = p.codigo.ToString();
            txtsemente.Text = p.sementeusada;
        }

        private void setProduto(Produto p)
        {
            txtprod.Text = p.codigo.ToString();
            txtdescricao.Text = p.descricao;
        }

        private void setFuncionario(funcionario f)
        {
            txtfunc.Text = f.codigo.ToString();
            txtnome.Text = f.nome;
        }

        private objacao getListaAcao()
        {
            objacao acao = new objacao();
            acao.codigo = Convert.ToInt32(dgvacoes.CurrentRow.Cells[0].Value.ToString());
            acao.tipoacao = dgvacoes.CurrentRow.Cells[1].Value.ToString();
            acao.plantacao = Convert.ToInt32(dgvacoes.CurrentRow.Cells[2].Value.ToString());
            acao.codigoprod = Convert.ToInt32(dgvacoes.CurrentRow.Cells[3].Value.ToString());
            acao.dataac = Convert.ToDateTime(dgvacoes.CurrentRow.Cells[4].Value.ToString());
            acao.funcionario = Convert.ToInt32(dgvacoes.CurrentRow.Cells[5].Value.ToString());
            acao.status = dgvacoes.CurrentRow.Cells[6].Value.ToString();
            acao.horario = dgvacoes.CurrentRow.Cells[7].Value.ToString();

            return acao;
        }

        public objacao getAcao()
        {
            objacao a = new objacao();
            a.codigo = Convert.ToInt32(txtcodigo.Text);
            a.tipoacao = txtipoac.Text;
            a.plantacao = Convert.ToInt32(txtplantacao.Text);
            a.codigoprod = Convert.ToInt32(txtprod.Text);
            a.dataac = Convert.ToDateTime(mskdata.Text);
            a.funcionario = Convert.ToInt32(txtfunc.Text);
            a.status = combstatus.SelectedItem.ToString();
            a.horario = txthorario.Text;

            return a;
        }

        public void setAcao(objacao a)
        {
            string status = a.status;
            int posicao = combstatus.Items.IndexOf(status);
            txtcodigo.Text = a.codigo.ToString();
            txtipoac.Text = a.tipoacao;
            txtplantacao.Text = a.plantacao.ToString();
            txtprod.Text = a.codigoprod.ToString();
            mskdata.Text = a.dataac.ToString();
            txtfunc.Text = a.funcionario.ToString();
            combstatus.Text = a.status.ToString();
            txthorario.Text = a.horario.ToString();

        }

        public void limpar()
        {
            txtcodigo.Clear();
            txtdescricao.Clear();
            txtipoac.Text = "";
            txtfunc.Clear();
            txtprod.Clear();
            txtsemente.Clear();
          
            combstatus.Text = "";
            txtplantacao.Clear();
            txtnome.Clear();
            txthorario.Clear();


        }

        public void limparbtn()
        {
            txtdescricao.Clear();
            txtipoac.Text = "";
            txtfunc.Clear();
            txtprod.Clear();
            txtsemente.Clear();
           
            combstatus.Text = "";
            txtplantacao.Clear();
            txtnome.Clear();
            txthorario.Clear();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limparbtn();
        }

        private void btnListaFunc_Click(object sender, EventArgs e)
        {
            frmlistafuncionario lf = new frmlistafuncionario();
            lf.ShowDialog();
            if (lf.DialogResult == DialogResult.OK)
            {
                funcionario f = lf.getfuncionario();
                txtfunc.Text = f.codigo.ToString();
                txtnome.Text = f.nome.ToString();

            }
        }

        private void btnListaProd_Click(object sender, EventArgs e)
        {
            Frmlistaproduto lp = new Frmlistaproduto();
            lp.ShowDialog();
            if (lp.DialogResult == DialogResult.OK)
            {
                Produto p = lp.getProduto();
                txtprod.Text = p.codigo.ToString();
                txtdescricao.Text = p.descricao.ToString();
            }
        }

        private void btnListaPlant_Click(object sender, EventArgs e)
        {
            frmListaPlantacoes p = new frmListaPlantacoes();
            p.ShowDialog();
            if (p.DialogResult == DialogResult.OK)
            {
                objplantacao op = p.GetPlantacao();
                txtplantacao.Text = op.codigo.ToString();
                txtsemente.Text = op.sementeusada.ToString();
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
           
            try
          
         {
                DAOacao da = new DAOacao();
                da.CadastarAcao(getAcao());
                MessageBox.Show("Ação cadastrada com sucesso !", "Cadastro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
                Atualizar();
                res = da.getCod() + 1;
                txtcodigo.Text = res + "";
            }
           catch (Exception)
            {
               MessageBox.Show("Não foi possível realizar o cadastro da ação, tente novamente", "Verifique se os dados estão corretos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                DAOacao da = new DAOacao();
                da.EditarAcao(getAcao());
                MessageBox.Show("Dados alterados", "Edição concluida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpar();
                btngravar.Enabled = true;
                btneditar.Enabled = false;
                btnexcluir.Enabled = false;
                Atualizar();
                res = da.getCod() + 1;
                txtcodigo.Text = res + "";
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível realizar a edição, tente novamente", "Verifique se os dados estão corretos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvacoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            setAcao(getListaAcao());
            btneditar.Enabled = true;
            btnexcluir.Enabled = true;
            btngravar.Enabled = false;

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir esta ação ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAOacao da = new DAOacao();
                    da.ExcluirAcao(Convert.ToInt32(txtcodigo.Text));
                    limpar();
                    btngravar.Enabled = true;
                    btneditar.Enabled = false;
                    btnexcluir.Enabled = false;
                    Atualizar();
                    res = da.getCod() + 1;
                    txtcodigo.Text = res + "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível realizar a exclusão, tente novamente", "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtfunc_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if ((txt.Name == txtfunc.Name) && (txt.Text != ""))
            {
                funcionario f = new DAOacao().ProcuraFuncionario(Int32.Parse(txtfunc.Text));
                if (f != null)
                {
                    setFuncionario(f);
                }
            }
        }

        private void txtprod_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if ((txt.Name == txtprod.Name) && (txt.Text != ""))
            {
                Produto p = new DAOacao().ProcuraProduto(Int32.Parse(txtprod.Text));
                if (p != null)
                {
                    setProduto(p);
                }
            }
        }

        private void txtplantacao_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if ((txt.Name == txtplantacao.Name) && (txt.Text != ""))
            {
                objplantacao p = new DAOacao().ProcuraPlantacao(Int32.Parse(txtplantacao.Text));
                if (p != null)
                {
                    setPlantacao(p);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txthorario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
