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
	public partial class Frm_Relacao_User : Form
	{
		public Frm_Relacao_User()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'farmsystemDB.usuario'. Você pode movê-la ou removê-la conforme necessário.
			//this.usuarioTableAdapter.Fill(this.farmsystemDB.usuario);

			this.Rp_Usuarios.RefreshReport();
		}
	}
}
