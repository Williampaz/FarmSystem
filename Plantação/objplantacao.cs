using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Plantação
{
    public class objplantacao
    {

        private int _codigo;
        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private int _funcionario;
        public int funcionario{
            get { return _funcionario; }
            set { _funcionario = value; }
            }

        private double _area;
        public double area
        {
            get { return _area; }
            set { _area = value; }
        }

        private double _distinciaentreplantas;
        public double distinciaentreplantas
        {
            get { return _distinciaentreplantas; }
            set { _distinciaentreplantas = value; }
        }

        private DateTime _datadeplantio;
        public DateTime datadeplantio
        {
            get { return _datadeplantio; }
            set { _datadeplantio = value; }
        }

        private string _valordevenda;
        public string valordevenda
        {
            get { return _valordevenda; }
            set { _valordevenda = value; }
        }

        private string _statusdaplantacao;
        public string statusdaplantacao
        {
            get { return _statusdaplantacao; }
            set { _statusdaplantacao = value; }
        }

        private int _previsaodecolheita;
        public int previsaodecolheita
        {
            get { return _previsaodecolheita; }
            set { _previsaodecolheita = value; }
        }
        private DateTime _prevdatacolheita;
        public DateTime prevdatacolheita
        {
            get { return _prevdatacolheita; }
            set { _prevdatacolheita = value; }
        }

        private int _quantidadecolhida;
        public int quantidadecolhida
        {
            get { return _quantidadecolhida; }
            set { _quantidadecolhida = value; }
        }

        private string _sementeusada;
        public string sementeusada
        {
            get { return _sementeusada; }
            set { _sementeusada = value; }
        }

        private DateTime _datadecolheita;
        public DateTime datadecolheita
        {
            get { return _datadecolheita; }
            set { _datadecolheita = value; }
        }

        /*
          codigo serial,
          funcionario int,
          area float,
          distinciaentreplantas float,
          datadeplantio date,
          valordevenda varchar(20),
          statusdaplantacao varchar(40),
          previsaodecolheita int,
          prevdatacolheita date,
          quantidadecolhida int,
          sementeusada varchar (40),  
         
         */

    }
}
