using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmSystem.Plantação;

namespace FarmSystem
{
    public partial class frmListaAcoes : Form
    {
        public frmListaAcoes()
        {
            InitializeComponent();
            DAOacao d = new DAOacao();
            dgvAcoes.DataSource = d.ListaAcoes();
        }

        public frmListaAcoes(objacao acao)
        {
            InitializeComponent();
            DAOacao d = new DAOacao();
            dgvAcoes.DataSource = d.ListaAcoes();
        }

        public objacao GetAcao()
        {
            objacao a = new objacao();
            a.codigo = Convert.ToInt32(dgvAcoes.CurrentRow.Cells[0].Value);
            a.tipoacao = dgvAcoes.CurrentRow.Cells[1].Value.ToString();
            a.plantacao = Convert.ToInt32(dgvAcoes.CurrentRow.Cells[2].Value);
            a.codigoprod = Convert.ToInt32(dgvAcoes.CurrentRow.Cells[3].Value);
            a.dataac = Convert.ToDateTime(dgvAcoes.CurrentRow.Cells[4].Value);
            a.funcionario = Convert.ToInt32(dgvAcoes.CurrentRow.Cells[5].Value);
            a.status = dgvAcoes.CurrentRow.Cells[6].Value.ToString();
            a.horario =  dgvAcoes.CurrentRow.Cells[7].Value.ToString();
            a.quantidade = Convert.ToInt32(dgvAcoes.CurrentRow.Cells[8].Value.ToString());

            return a;
        }

        private void dgvAcoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            DAOacao da = new DAOacao();
            dgvAcoes.DataSource = da.ListaAcoes(txtPesquisar.Text);
        }

        private void frmListaAcoes_Load(object sender, EventArgs e)
        {

        }
    }
}
