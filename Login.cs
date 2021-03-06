﻿using FarmSystem.Principal;
using FarmSystem.usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem
{
	public partial class Login : Form
	{
		public bool logado = false;
		public string email;
		public Login()
		{
			InitializeComponent();
			User_DAO user = new User_DAO();
			
			if(user.bustatodos() == null)
			{
				MessageBox.Show("Por Favor faça o primeiro cadastro de usuário.");
				new Frm_Cad_User().ShowDialog();
			}
		}

		public void Logar()
        {
			User_DAO car = new User_DAO();
			car.logar(txt_Usuario.Text, txt_Senha.Text);
			if (car.logar(txt_Usuario.Text, txt_Senha.Text) == true)
			{
				logado = true;
				email = txt_Usuario.Text;
				this.Close();
		
			}
			else
			{
				txt_Senha.Clear();
				MessageBox.Show("Usuario ou senha invalidos");
			}
		}

		private void btn_Sair_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_Entrar_Click(object sender, EventArgs e)
		{
			Logar();
		}

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
				Logar();
        }
    }
}
