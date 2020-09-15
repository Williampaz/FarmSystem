using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem.Plantação
{
    public partial class acoes : Form
    {
        public acoes()
        {
            InitializeComponent();
        }

        private void acoes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'postgresDataSet2.acoes'. Você pode movê-la ou removê-la conforme necessário.
            this.acoesTableAdapter.Fill(this.postgresDataSet2.acoes);
            // TODO: esta linha de código carrega dados na tabela 'postgresDataSet2.acoes'. Você pode movê-la ou removê-la conforme necessário.
            this.acoesTableAdapter.Fill(this.postgresDataSet2.acoes);
            // TODO: esta linha de código carrega dados na tabela 'postgresDataSet2.acoes'. Você pode movê-la ou removê-la conforme necessário.
            this.acoesTableAdapter.Fill(this.postgresDataSet2.acoes);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void limpar()
        {
            txtcodigo.Clear();
            txtdrescricao.Clear();
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

        }
    }
}
