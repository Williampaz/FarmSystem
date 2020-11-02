
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Fornecedores
{
	public class Fornecedor
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

        private string _telefone;
        public string telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        private string _endereco;
        public string endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        private string _cnpj;
        public string cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        private string _cidade;
        public string cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        private string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
