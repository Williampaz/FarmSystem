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
            this.acoesTableAdapter.Fill(this.postgresDataSet2.acoes);

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
            return a;
        }

        public void setAcao(objacao a)
        {
            txtcodigo.Text = a.codigo.ToString();
            txtipoac.Text = a.tipoacao;
            txtplantacao.Text = a.plantacao.ToString();
            txtprod.Text = a.codigoprod.ToString();
            mskdata.Text = a.dataac.ToString();
            txtfunc.Text = a.funcionario.ToString();
            combstatus.SelectedItem = a.status;
        }

        public void limpar()
        {
            txtcodigo.Clear();
            txtdescricao.Clear();
            txtipoac.Clear();
            txtfunc.Clear();
            txtprod.Clear();
            txtsemente.Clear();
            mskdata.Clear();
            combstatus.Text = "";
            txtplantacao.Clear();
            txtnome.Clear();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpar();
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
            if(lp.DialogResult == DialogResult.OK)
            {
                Produto p = lp.getProduto();
                txtprod.Text = p.codigo.ToString();
                txtsemente.Text = p.nome.ToString();
            }
        }
    }
}
