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
    public partial class frmfuncionario : Form
    {
        public frmfuncionario()
        {
            InitializeComponent();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private funcionario getfuncionario()
        {
            funcionario func = new funcionario();
            func.nome = txtnome.Text;
            func.idade = txtidade.Text;
            func.datanasc = Convert.ToDateTime(mskdtanasc.Text);
            func.fone = msktel.Text;
            func.endereco = txtendereco.Text;
            func.dataadmissao = Convert.ToDateTime(mskdtaadm.Text);
            func.cargo = txtcargo.Text;
            func.salario = Convert.ToDouble(txtsalario.Text);
                
                return func;

        }
        private void setfuncionario(funcionario f)
        {
            txtcodigo.Text = f.codigo.ToString();
            txtnome.Text = f.nome;
            txtidade.Text = f.idade;
            mskdtanasc.Text = f.datanasc.ToString();
            msktel.Text = f.fone;
            txtendereco.Text = f.endereco;
            mskdtaadm.Text = f.dataadmissao.ToString();
            txtcargo.Text = f.cargo;
            txtsalario.Text = f.salario.ToString();
        }

        private void limpar()
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtidade.Clear();
            mskdtanasc.Clear();
            msktel.Clear();
            txtendereco.Clear();
            mskdtaadm.Clear();
            txtcargo.Clear();
            txtsalario.Clear();
            


        }
        private void btngravar_Click(object sender, EventArgs e)
        {
            try
            {
                daofuncionario df = new daofuncionario();

                df.Cadastar(getfuncionario());

                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro Realizado");
                limpar();
            }
            catch
            {
                MessageBox.Show("Erro ao Cadastrar, por favor verifique se todos campo estão preenchidos");
            }
        
          

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            daofuncionario df = new daofuncionario();
            df.Editar(getfuncionario());
            limpar();
            MessageBox.Show("Dados alterados com sucesso", "Dados alterados");
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

            daofuncionario df = new daofuncionario();
            df.Excluir(Convert.ToInt32(txtcodigo.Text));
            limpar();
            MessageBox.Show("Excluido", "Exclusão");
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            frmlistafuncionario lf = new frmlistafuncionario();
            lf.ShowDialog();

            if (lf.DialogResult == DialogResult.OK)
            {
                setfuncionario(lf.getfuncionario());

            }
          
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;
            if ((txt.Name == txtcodigo.Name) && (txt.Text != ""))
            {
                funcionario f = new daofuncionario().buscafuncid(Int32.Parse(txtcodigo.Text));
              

                if (f != null)
                {
                    setfuncionario(f);
                }
            }
        }

        private void frmfuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
