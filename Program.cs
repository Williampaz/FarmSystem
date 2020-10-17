using FarmSystem.Principal;
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
			Login log = new Login();
			log.ShowDialog();
			if(log.logado == true)
            {
				Application.Run(new Frm_Inicial());
			}
		}
	}
}
