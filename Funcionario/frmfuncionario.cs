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
            daofuncionario df = new daofuncionario();
            res = df.getCod() + 1;
            txtcodigo.Text = res + "";
            btneditar.Enabled = false;
            btnexcluir.Enabled = false;
        }

        int res;

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private funcionario getcadfuncionario()
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

        private funcionario getfuncionario()
        {
            funcionario func = new funcionario();
            func.codigo = Convert.ToInt32(txtcodigo.Text);
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

        public void limparbtn()
        {
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

                df.Cadastar(getcadfuncionario());

                MessageBox.Show("Funcionário cadastrado com sucesso !", "Cadastro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
            }
            catch
            {
                MessageBox.Show("Erro ao Cadastrar, por favor verifique se todos campo estão preenchidos","Não foi possível realizar o cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                daofuncionario df = new daofuncionario();
                df.Editar(getfuncionario());
                limpar();
                MessageBox.Show("Dados alterados com sucesso", "Dados alterados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btngravar.Enabled = true;
                btneditar.Enabled = false;
                btnexcluir.Enabled = false;
                res = df.getCod() + 1;
                txtcodigo.Text = res + "";
            }
            catch
            {
                MessageBox.Show("Erro ao Editar, por favor verifique se os dados estão corretos", "Não foi possível realizar a edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Deseja excluir este cadastro ?", "Excluir funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    daofuncionario df = new daofuncionario();
                    df.Excluir(Convert.ToInt32(txtcodigo.Text));
                    limpar();
                    MessageBox.Show("Cadastro de funcionário excluido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btngravar.Enabled = true;
                    btneditar.Enabled = false;
                    btnexcluir.Enabled = false;
                    res = df.getCod() + 1;
                    txtcodigo.Text = res + "";
                }
                else
                {
                    limpar();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao excluir, por favor verifique se há um funcionário selecionado", "Não foi possível realizar a exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            try
            {
                frmlistafuncionario lf = new frmlistafuncionario();
                lf.ShowDialog();

                if (lf.DialogResult == DialogResult.OK)
                {
                    setfuncionario(lf.getfuncionario());
                    btneditar.Enabled = true;
                    btnexcluir.Enabled = true;
                    btngravar.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro, por favor tente novamente", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limparbtn();
        }

        private void txtnome_Leave(object sender, EventArgs e)
        {
            epdFuncionario.Clear();
            if (txtnome.Text.Equals(""))
            {
                epdFuncionario.SetError(txtnome, "Preencha este campo");
                txtnome.Focus();
                return;
            }
        }

        private void txtidade_Leave(object sender, EventArgs e)
        {
            epdFuncionario.Clear();
            if (txtidade.Text.Equals(""))
            {
                epdFuncionario.SetError(txtidade, "Preencha este campo");
                txtidade.Focus();
                return;
            }
        }

        private void txtendereco_Leave(object sender, EventArgs e)
        {
            epdFuncionario.Clear();
            if (txtendereco.Text.Equals(""))
            {
                epdFuncionario.SetError(txtendereco, "Preencha este campo");
                txtendereco.Focus();
                return;
            }
        }

        private void txtcargo_Leave(object sender, EventArgs e)
        {
            epdFuncionario.Clear();
            if (txtcargo.Text.Equals(""))
            {
                epdFuncionario.SetError(txtcargo, "Preencha este campo");
                txtcargo.Focus();
                return;
            }
        }

        private void txtsalario_Leave(object sender, EventArgs e)
        {
            epdFuncionario.Clear();
            if (txtsalario.Text.Equals(""))
            {
                epdFuncionario.SetError(txtsalario, "Preencha este campo");
                txtsalario.Focus();
                return;
            }
        }

        private void mskdtanasc_Leave(object sender, EventArgs e)
        {
            epdFuncionario.Clear();
            if (!mskdtanasc.MaskCompleted)
            {
                epdFuncionario.SetError(mskdtanasc, "Preencha este campo");
                mskdtanasc.Focus();
                return;
            }
        }

        private void msktel_Leave(object sender, EventArgs e)
        {
            epdFuncionario.Clear();
            if (!msktel.MaskCompleted)
            {
                epdFuncionario.SetError(msktel, "Preencha este campo");
                msktel.Focus();
                return;
            }
        }

        private void mskdtaadm_Leave(object sender, EventArgs e)
        {
            epdFuncionario.Clear();
            if (!mskdtaadm.MaskCompleted)
            {
                epdFuncionario.SetError(mskdtaadm, "Preencha este campo");
                mskdtaadm.Focus();
                return;
            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
