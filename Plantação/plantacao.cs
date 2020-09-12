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
    public partial class plantacao : Form
    {
        public plantacao()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void plantacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'postgresDataSet2.plantacao'. Você pode movê-la ou removê-la conforme necessário.
            this.plantacaoTableAdapter.Fill(this.postgresDataSet2.plantacao);
           

        }
    }
}
