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

 

        private void btngravar_Click(object sender, EventArgs e)
        {

        }
    }
}
