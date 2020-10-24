using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: esta linha de código carrega dados na tabela 'postgresDataSet4.acoes'. Você pode movê-la ou removê-la conforme necessário.
            this.acoesTableAdapter.Fill(this.postgresDataSet4.acoes);

            this.reportViewer1.RefreshReport();
        }
    }
}
