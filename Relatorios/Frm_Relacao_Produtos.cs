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
    public partial class Frm_Relacao_Produtos : Form
    {
        public Frm_Relacao_Produtos()
        {
            InitializeComponent();
        }

        private void Frm_Relacao_Produtos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'postgresDataSet1.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.postgresDataSet1.produtos);

            this.reportViewer1.RefreshReport();
        }
    }
}
