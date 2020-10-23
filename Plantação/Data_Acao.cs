using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Plantação
{
	public class Data_Acao
	{
        private int _codigo;
        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _semente_usada;
        public string semente_usada
        {
            get { return _semente_usada; }
            set { _semente_usada = value; }
        }
        private string _nome_produto;
        public string nome_produto
        {
            get { return _nome_produto; }
            set { _nome_produto = value; }
        }
        private string _nome_funcionario;
        public string nome_funcionario
        {
            get { return _nome_funcionario; }
            set { _nome_funcionario = value; }
        }
        private DateTime _data_acao;
        public DateTime data_acao
        {
            get { return _data_acao; }
            set { _data_acao = value; }
        }
        private string _Tipo_Acao;
        public string Tipo_Acao
        {
            get { return _Tipo_Acao; }
            set { _Tipo_Acao = value; }
        }
        private string _Status;
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        private string _Horario;
        public string Horario
        {
            get { return _Horario; }
            set { _Horario = value; }
        }
    }
}
