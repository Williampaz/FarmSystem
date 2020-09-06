using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem.Relatorios
{
	public partial class Frm_Relacao_Produtos : Form
	{
		public Frm_Relacao_Produtos()
		{
			InitializeComponent();
		}

		private void Frm_Relacao_Produtos_Load(object sender, EventArgs e)
		{

			this.reportViewer1.RefreshReport();
		}
	}
}
