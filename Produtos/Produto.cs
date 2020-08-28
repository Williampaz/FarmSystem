using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FarmSystem.Produtos
{
	class Produto
	{
        private int _codigo;
        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private int _codigoforn;
        public int codigoforn
        {
            get { return _codigoforn; }
            set { _codigoforn = value; }
        }
        private string _tipoprod;
        public string tipoprod
        {
            get { return _tipoprod; }
            set { _tipoprod = value; }
        }
        private string _nome;
        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public int _quantidade;
        public int quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        private string _mesdeuso;
        public string mesdeuso
        {
            get { return _mesdeuso; }
            set { _mesdeuso = value; }
        }
        private DateTime _validade;
        public DateTime validade
        {
            get { return _validade; }
            set { _validade = value; }
        }
        private DateTime _mesdeplantio;
        public DateTime mesdeplantio
        {
            get { return _mesdeplantio; }
            set { _mesdeplantio = value; }
        }
        private int _diacolheita;
        public int diacolheita
        {
            get { return _diacolheita; }
            set { _diacolheita = value; }
        }
        private Double _precokg_uni;
        public Double preçokg_uni
        {
            get { return preçokg_uni; }
            set { preçokg_uni = value; }
        }
        private string _descricao;
        public string descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
    }
}
