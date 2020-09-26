using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{

	class Conexao
	{
		private string connString = String.Format("Server=127.0.0.1;Port=5432;User Id=postgres;Password=ads05123;Database=postgres");
		private NpgsqlConnection conn;
		public Conexao()
		{
			conn = new NpgsqlConnection(connString);
		}
		public NpgsqlConnection entrar()
		{
			if (conn.State == System.Data.ConnectionState.Closed)
			{
				conn.Open();
				return conn;
			}

			return conn;
		}
		public void sair()
		{
			conn.Close();
		}
	}
}
