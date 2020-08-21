using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Funcionario
{
    public class funcionario
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

        private string _idade;
        public string idade
        {
            get { return _idade; }
            set { _idade = value; }
         }

        private DateTime _datanasc;
        public DateTime datanasc
        {
            get { return _datanasc; }
            set { _datanasc = value; }
        }

        private string _fone;
        public string fone
        {
            get { return _fone; }
            set { _fone = value; }
        }

        private String _endereco;
        public string endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        private DateTime _dataadmissao;
        public DateTime dataadmissao
        {
            get { return _dataadmissao; }
            set { _dataadmissao = value; }
        }

        private string _cargo;

        public string cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        private double _salario;

        public double salario
        {
            get { return _salario; }
            set { _salario = value; }
        }

        }
}
