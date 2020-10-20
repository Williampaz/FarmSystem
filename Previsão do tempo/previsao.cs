using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Npgsql;
using NpgsqlTypes;
using FarmSystem.Principal;

namespace FarmSystem.Previsão_do_tempo
{
    public partial class previsao : Form
    {
        public previsao()
        {
            InitializeComponent();

        }

        public previsao(int user)
        {
            InitializeComponent();
            txtusu.Text = user.ToString();

        }


        string city = "";

            string pasta_aplicacao = Application.StartupPath + @"\"; // pega endereço da pasta que contem arquivo executavel 
        

            public void getWeather(string key, string city)
            {
                string url = string.Format("https://api.hgbrasil.com/weather?key={0}&city_name={1}&format=json", key, city);
                WebClient web = new WebClient();

                var json = web.DownloadString(url);
                byte[] bytes = Encoding.Default.GetBytes(json);
                json = Encoding.UTF8.GetString(bytes);
                var result = JsonConvert.DeserializeObject<WeatherInfo.RootObject>(json);
                WeatherInfo.RootObject outPut = result;


                //Convertendo dias da semana para portugues
                string day = DateTime.Today.DayOfWeek.ToString();
                string dayWeek = "";
                switch (day)
                {
                    case "Monday":
                        dayWeek = "Segunda-feira";
                        break;
                    case "Tuesday":
                        dayWeek = "Terça-feira";
                        break;
                    case "Wednesday":
                        dayWeek = "Quarta-feira";
                        break;
                    case "Thursday":
                        dayWeek = "Quinta-feira";
                        break;
                    case "Friday":
                        dayWeek = "Sexta-feira";
                        break;
                    case "Saturday":
                        dayWeek = "Sábado";
                        break;
                    case "Sunday":
                        dayWeek = "Domingo";
                        break;
                    default:
                        dayWeek = "ERROR";
                        break;
                }

                //Preenchendo campos do form

                lbl_cidade.Text = outPut.results.city_name;

                lbl_diaSemana1.Text = outPut.results.forecast[0].weekday.ToString();
                lbl_diaSemana2.Text = outPut.results.forecast[1].weekday.ToString();
                lbl_diaSemana3.Text = outPut.results.forecast[2].weekday.ToString();
                lbl_diaSemana4.Text = outPut.results.forecast[3].weekday.ToString();
                lbl_diaSemana5.Text = outPut.results.forecast[4].weekday.ToString();

                lbl_max1.Text = outPut.results.forecast[0].max.ToString();
                lbl_max2.Text = outPut.results.forecast[1].max.ToString();
                lbl_max3.Text = outPut.results.forecast[2].max.ToString();
                lbl_max4.Text = outPut.results.forecast[3].max.ToString();
                lbl_max5.Text = outPut.results.forecast[4].max.ToString();

                lbl_min1.Text = outPut.results.forecast[0].min.ToString();
                lbl_min2.Text = outPut.results.forecast[1].min.ToString();
                lbl_min3.Text = outPut.results.forecast[2].min.ToString();
                lbl_min4.Text = outPut.results.forecast[3].min.ToString();
                lbl_min5.Text = outPut.results.forecast[4].min.ToString();

                pb_dia1.Image = Image.FromFile(pasta_aplicacao + @"images\" + outPut.results.forecast[0].condition.ToString() + ".png");
                pb_dia2.Image = Image.FromFile(pasta_aplicacao + @"images\" + outPut.results.forecast[1].condition.ToString() + ".png");
                pb_dia3.Image = Image.FromFile(pasta_aplicacao + @"images\" + outPut.results.forecast[2].condition.ToString() + ".png");
                pb_dia4.Image = Image.FromFile(pasta_aplicacao + @"images\" + outPut.results.forecast[3].condition.ToString() + ".png");
                pb_dia5.Image = Image.FromFile(pasta_aplicacao + @"images\" + outPut.results.forecast[4].condition.ToString() + ".png");
                pb_diaAtual.Image = Image.FromFile(pasta_aplicacao + @"images\" + outPut.results.condition_slug.ToString() + ".png");

                lbl_diaSemana.Text = dayWeek + "   " + outPut.results.time;
                lbl_descricao.Text = outPut.results.description;
                lbl_tempAtual.Text = outPut.results.temp.ToString();
                lbl_umidade.Text = outPut.results.humidity + "%";
                lbl_velocidadeVento.Text = outPut.results.wind_speedy.ToString();
                lbl_porDoSol.Text = outPut.results.sunset;

                toolTip1.SetToolTip(pb_diaAtual, outPut.results.description.ToString());
                toolTip1.SetToolTip(pb_dia1, outPut.results.forecast[0].description.ToString());
                toolTip1.SetToolTip(pb_dia2, outPut.results.forecast[1].description.ToString());
                toolTip1.SetToolTip(pb_dia3, outPut.results.forecast[2].description.ToString());
                toolTip1.SetToolTip(pb_dia4, outPut.results.forecast[3].description.ToString());
                toolTip1.SetToolTip(pb_dia5, outPut.results.forecast[4].description.ToString());


            }





            public void CarregaWeather()
            {
                string key = "6756e309";

                while (true)
                {
                    try
                    {
                        getWeather(key, city); //caso não de erro
                        break;
                    }
                    catch (WebException)
                    {
                        if (key == "6756e309")//primeira chave
                            key = "843e3657"; //segunda chave
                        else
                        {
                            MessageBox.Show("Serviço temporariamente indisponível");
                            break;
                        }
                    }
                }
            }


        private string getcidade(int user)
        {

            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("select cidade from farmsystem.usuario where codigo = @user ");
            query.Parameters.Add("@user", NpgsqlDbType.Integer).Value =user;
            query.Connection = conn.entrar();
            string cid = "";
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cid = dr.GetString(0);
                    }
                    conn.sair();
                    return cid;
                }
            }
            conn.sair();
            return cid;
        }

            private void previsao_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.F1)
                {
                    textBox1.Visible = true;
                }

                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        city = textBox1.Text;

                        textBox1.Visible = false;
                        textBox1.Focus();
                        CarregaWeather();
                    }
                }

                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }

            }

            private void Form1_Load(object sender, EventArgs e)
            {

            

        }


        

        private void previsao_Load(object sender, EventArgs e)
        {
            Conexao conn = new Conexao();

            string cid;
           
            cid = getcidade(Int32.Parse(txtusu.Text));

            city = cid;


            CarregaWeather();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


