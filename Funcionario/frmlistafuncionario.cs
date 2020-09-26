using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem.Funcionario
{
    public partial class frmlistafuncionario : Form
    {
        public frmlistafuncionario()
        {
            InitializeComponent();
            daofuncionario df = new daofuncionario();
            dgvfuncionarios.DataSource = df.Listafuncioario();
        }



        public funcionario getfuncionario()
        {
            funcionario f  = new funcionario();
            f.codigo = Convert.ToInt32(dgvfuncionarios.CurrentRow.Cells[0].Value);
            f.nome = dgvfuncionarios.CurrentRow.Cells[1].Value.ToString();
            f.idade = dgvfuncionarios.CurrentRow.Cells[2].Value.ToString();
            f.datanasc = Convert.ToDateTime(dgvfuncionarios.CurrentRow.Cells[3].Value.ToString());
            f.fone = dgvfuncionarios.CurrentRow.Cells[4].Value.ToString();
            f.endereco = dgvfuncionarios.CurrentRow.Cells[5].Value.ToString();
            f.dataadmissao   = Convert.ToDateTime(dgvfuncionarios.CurrentRow.Cells[6].Value.ToString());
            f.cargo = dgvfuncionarios.CurrentRow.Cells[7].Value.ToString();
            f.salario = Convert.ToDouble(dgvfuncionarios.CurrentRow.Cells[8].Value.ToString());
            
            return f;
        }



        private void frmlistafuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmsystemDB.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            //this.funcionarioTableAdapter.Fill(this.farmsystemDB.funcionario);
       

        }



        private void txtPesquisarForn_TextChanged(object sender, EventArgs e)
        {
            daofuncionario df = new daofuncionario();
            dgvfuncionarios.DataSource = df.listafunciorio(txtpesquisa.Text);

        }

   

        private void dgvfuncionarios_CellDoubleClick_2(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dgvfuncionarios_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
