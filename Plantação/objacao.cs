using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Plantação
{
   public class objacao
    {

        private int _codigo;
        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private String _tipoacao;
        public String tipoacao
        {
            get { return _tipoacao; }
            set { _tipoacao = value; }
        }

        private int _plantacao;
        public int plantacao
        {
            get { return _plantacao; }
            set { _plantacao = value; }
        }

        private int _codigoprod;
        public int codigoprod
        {
            get { return _codigoprod; }
            set { _codigo = value; }
        }

        private DateTime _dataac;
        public DateTime dataac
        {
            get { return _dataac; }
            set { _dataac = value; }
        }

        private int _funcionario;
        public int funcionario
        {
            get { return _funcionario; }
            set { _funcionario = value; }
        }

        private String _status;
        public String status
        {
            get { return _status; }
            set { _status = value; }
        }


    }
}
