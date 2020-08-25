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
    public partial class Frmlistaproduto : Form
    {
        public Frmlistaproduto()
        {
            InitializeComponent();
            DAOproduto df = new DAOproduto();
            dvgprod.DataSource = df.ListaProduto();
        }

      
        public Frmlistaproduto(Produto p)
        {
            InitializeComponent();
            DAOproduto df = new DAOproduto();
            dvgprod.DataSource = df.ListaProduto();
        }

        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            DAOproduto d = new DAOproduto();
            dvgprod.DataSource = d.ListaProduto(txtbusca.Text);
        }
    }
}
