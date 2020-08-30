using FarmSystem.usuario;
using FarmSystem.Fornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmSystem.Funcionario;
using FarmSystem.Produtos;

namespace FarmSystem.Principal
{
	public partial class Frm_Inicial : Form
	{
		public Frm_Inicial()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new Frm_Cad_User().ShowDialog();  
		}

		private void button2_Click(object sender, EventArgs e)
		{
			new frmCadastroFornecedor().ShowDialog();
		}

        private void button3_Click(object sender, EventArgs e)
        {
			new frmfuncionario().ShowDialog();

        }

        private void Frm_Inicial_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
			new Frm_Cad_Prod().ShowDialog();

        }
    }
}
