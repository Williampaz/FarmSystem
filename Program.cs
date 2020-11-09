using FarmSystem.Principal;
using FarmSystem.usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem
{
	static class Program
	{
		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//new Frm_Inicial().ShowDialog();
			Login log = new Login();
			log.ShowDialog();
			if(log.logado == true)
            {
				
				User_DAO car = new User_DAO();
			new Frm_Inicial(car.buscacod(log.email), car.bucanome(log.email)).ShowDialog();
			}
		}
	}
}
