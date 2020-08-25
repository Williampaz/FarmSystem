using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Produto
{
    class Produto
    {
        private int _codigo;

        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public int codigoforn
        {
            get { return codigoforn; }
            set { codigoforn = value; }
        }
        public string tipoprod
        {
            get { return tipoprod; }
            set { tipoprod = value; }
        }
        public string nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public int mesdeuso
        {
            get { return mesdeuso; }
            set { mesdeuso = value; }
        }
        public int validade
        {
            get { return validade; }
            set { validade = value; }
        }
        public int mesdeplantio
        {
            get { return mesdeplantio; }
            set { mesdeplantio = value; }
        }
        public int diacolheita
        {
            get { return diacolheita; }
            set { diacolheita = value; }
        }
        public int preçokg_uni
        {
            get { return preçokg_uni; }
            set { preçokg_uni = value; }
        }
        public string descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

    }
}
