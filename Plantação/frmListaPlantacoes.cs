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
    public partial class frmListaPlantacoes : Form
    {
        public frmListaPlantacoes()
        {
            InitializeComponent();
            daoplantacao dp = new daoplantacao();
            dgvPlantacoes.DataSource = dp.Listaplantacao();
        }
        
        public objplantacao GetPlantacao()
        {
            objplantacao p = new objplantacao();
            p.codigo = Convert.ToInt32(dgvPlantacoes.CurrentRow.Cells[0].Value);
            p.funcionario = Convert.ToInt32(dgvPlantacoes.CurrentRow.Cells[1].Value);
            p.area = Convert.ToDouble(dgvPlantacoes.CurrentRow.Cells[2].Value.ToString());
            p.distinciaentreplantas = Convert.ToDouble(dgvPlantacoes.CurrentRow.Cells[3].Value.ToString());
            p.datadeplantio = Convert.ToDateTime(dgvPlantacoes.CurrentRow.Cells[4].Value.ToString());
            p.valordevenda = dgvPlantacoes.CurrentRow.Cells[5].Value.ToString();
            p.statusdaplantacao = dgvPlantacoes.CurrentRow.Cells[6].Value.ToString();
            p.previsaodecolheita = Convert.ToInt32(dgvPlantacoes.CurrentRow.Cells[7].Value);
            p.prevdatacolheita = Convert.ToDateTime(dgvPlantacoes.CurrentRow.Cells[8].Value.ToString());
            p.quantidadecolhida = Convert.ToInt32(dgvPlantacoes.CurrentRow.Cells[9].Value);
            p.sementeusada = dgvPlantacoes.CurrentRow.Cells[10].Value.ToString();
            return p;
        }

        private void dgvPlantacoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            daoplantacao dp = new daoplantacao();
            dgvPlantacoes.DataSource = dp.Listaplantacao(txtPesquisar.Text);
        }
    }
}
