using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.usuario
{
	class User
	{
        private int _codigo;
        public int codigo
		{
			get { return _codigo; }
            set { _codigo = value; }
		}
		private string _nome;
		public string nome
		{
			get { return _nome; }
			set { _nome = value; }
		}
		private string _rg;
		public string rg
		{
			get { return _rg; }
			set { _rg = value; }
		}
		private string _cpf;
		public string cpf
		{
			get { return _cpf; }
			set { _cpf = value; }
		}
		private DateTime _nascimento;
		public DateTime nascimento
		{
			get { return _nascimento; }
			set { _nascimento = value; }
		}
		private string _idade;
		public string idade
		{
			get { return _idade; }
			set { _idade = value; }
		}
		private string _email;
		public string email
		{
			get { return _email; }
			set { _email = value; }
		}
		private string _senha;
		public string senha
		{
			get { return _senha; }
			set { _senha = value; }
		}
		private float _endereco;
		public float endereco
		{
			get { return _endereco; }
			set { _endereco = value; }
		}


	}
}
