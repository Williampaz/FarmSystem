using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem.usuario
{
	public partial class Frm_Sel_User : Form
	{
		public Frm_Sel_User()
		{
			InitializeComponent();
			User_DAO user = new User_DAO();
			data_usuario.DataSource = user.bustaUsuarios();
		}

		private void Frm_Sel_User_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'postgresDataSet.usuario'. Você pode movê-la ou removê-la conforme necessário.
			//this.usuarioTableAdapter.Fill(this.postgresDataSet.usuario);
		}
		public User GetUser()
		{
			User user = new User();
			user.codigo = Convert.ToInt32(data_usuario.CurrentRow.Cells[0].Value);
			user.nome = data_usuario.CurrentRow.Cells[1].Value.ToString();
			user.rg = data_usuario.CurrentRow.Cells[2].Value.ToString();
			user.cpf = data_usuario.CurrentRow.Cells[3].Value.ToString();
			user.nascimento = Convert.ToDateTime(data_usuario.CurrentRow.Cells[4].Value.ToString());
			user.idade = data_usuario.CurrentRow.Cells[5].Value.ToString();
			user.email = data_usuario.CurrentRow.Cells[6].Value.ToString();
			user.senha = data_usuario.CurrentRow.Cells[7].Value.ToString();
			user.endereco = data_usuario.CurrentRow.Cells[8].Value.ToString();
			return user;
		}
		private void data_usuario_DoubleClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void data_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
