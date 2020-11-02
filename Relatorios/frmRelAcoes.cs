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
using Microsoft.Reporting.WinForms;

namespace FarmSystem
{
    public partial class frmRelAcoes : Form
    {
        public frmRelAcoes()
        {
            InitializeComponent();
        }

        private void frmRelAcoes_Load(object sender, EventArgs e)
        {
           // cbbPlantacao.DataSource = new daoplantacao().Listaplantacao();
           // cbbPlantacao.DisplayMember = "codigo";

            // TODO: esta linha de código carrega dados na tabela 'postgresDataSet2.acoes'. Você pode movê-la ou removê-la conforme necessário.
            this.acoesTableAdapter.Fill(this.postgresDataSet2.acoes);

            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter("par_plantacao",cbbPlantacao.SelectedValue.ToString()));

            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("plantacao", txtplantacao.Text));
            this.reportViewer1.RefreshReport();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("plantacao", (string)null));
            this.reportViewer1.RefreshReport();
        }

        private void btnListaPlant_Click(object sender, EventArgs e)
        {
            frmListaPlantacoes lp = new frmListaPlantacoes();

            lp.ShowDialog();
            if (lp.DialogResult == DialogResult.OK)
            {
                objplantacao op = lp.GetPlantacao();
                txtplantacao.Text = op.codigo.ToString();
                txtsemente.Text = op.sementeusada.ToString();
            }
        }
    }
}
