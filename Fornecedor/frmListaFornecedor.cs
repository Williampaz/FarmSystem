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
	public partial class frmListaFornecedor : Form
	{
        public frmListaFornecedor()
        {
            InitializeComponent();
            DAOfornecedor df = new DAOfornecedor();
            dgvFornecedores.DataSource = df.ListaFornecedores();
        }

        public frmListaFornecedor(Fornecedor f)
        {
            InitializeComponent();
            DAOfornecedor df = new DAOfornecedor();
            dgvFornecedores.DataSource = df.ListaFornecedores();
        }

        public Fornecedor GetFornecedor()
        {
            Fornecedor f = new Fornecedor();
            f.codigo = Convert.ToInt32(dgvFornecedores.CurrentRow.Cells[0].Value);
            f.nome = dgvFornecedores.CurrentRow.Cells[1].Value.ToString();
            f.telefone = dgvFornecedores.CurrentRow.Cells[2].Value.ToString();
            f.endereco = dgvFornecedores.CurrentRow.Cells[3].Value.ToString();
            f.cnpj = dgvFornecedores.CurrentRow.Cells[4].Value.ToString();
            f.cidade = dgvFornecedores.CurrentRow.Cells[5].Value.ToString();
            f.email = dgvFornecedores.CurrentRow.Cells[6].Value.ToString();
            return f;
        }

        private void dgvFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtPesquisarForn_TextChanged(object sender, EventArgs e)
        {
            DAOfornecedor d = new DAOfornecedor();
            dgvFornecedores.DataSource = d.ListaFornecedores(txtPesquisarForn.Text);
        }

		private void dgvFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

        private void frmListaFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
