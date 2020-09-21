using FarmSystem.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem.Plantação
{
    public partial class plantacao : Form
    {
        public plantacao()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private objplantacao GetPlantacao()
        {
          
            objplantacao plant  = new objplantacao();

            plant.funcionario = Convert.ToInt32(txtcodfunc.Text);
            plant.area = Convert.ToDouble(txtarea.Text);
            plant.distinciaentreplantas = Convert.ToDouble(txtdistancia.Text);
            plant.datadeplantio = Convert.ToDateTime(mskdataplantio.Text);
            plant.valordevenda = txtvalorvenda.Text;
            plant.statusdaplantacao = txtstatus.Text;
            plant.previsaodecolheita = Convert.ToInt32(txtprevisaosacas.Text);
            plant.prevdatacolheita = Convert.ToDateTime(mskprevisaodata.Text);
            plant.quantidadecolhida = Convert.ToInt32(txtqtdsacas.Text);
            plant.sementeusada = txtsemente.Text;
                      

            return plant;
        }

        private void setplantacao(objplantacao plant)
        {
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
            txtcodigo.Text = plant.codigo.ToString();
            txtcodfunc.Text = plant.funcionario.ToString();
            txtarea.Text = plant.area.ToString();
            txtdistancia.Text = plant.distinciaentreplantas.ToString();
            mskdataplantio.Text = plant.datadeplantio.ToString();
            txtvalorvenda.Text = plant.valordevenda;
            txtstatus.Text = plant.statusdaplantacao;
            txtprevisaosacas.Text = plant.previsaodecolheita.ToString();
            mskprevisaodata.Text = plant.prevdatacolheita.ToString();
            txtqtdsacas.Text = plant.quantidadecolhida.ToString();
            txtsemente.Text = plant.sementeusada;
                     
        }

        private void limpar()
        {
            txtcodigo.Clear();
            txtcodfunc.Clear();
            txtnomefunc.Clear();
            txtarea.Clear();
            txtdistancia.Clear();
            mskdataplantio.Text = "";
            txtvalorvenda.Clear();
            txtstatus.Clear();
            txtprevisaosacas.Clear();
            mskprevisaodata.Text = "";
            txtqtdsacas.Clear();
            txtsemente.Clear();

        }

        private void plantacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'postgresDataSet2.plantacao'. Você pode movê-la ou removê-la conforme necessário.
            this.plantacaoTableAdapter.Fill(this.postgresDataSet2.plantacao);

            daoplantacao dp = new daoplantacao();
            dtgplantacao.DataSource = dp.Listaplantacao();
                       

        }

        private void btnacoes_Click(object sender, EventArgs e)
        {
            new acoes().ShowDialog();

        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                daoplantacao dp = new daoplantacao();

                dp.cadastrar(GetPlantacao());

                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro Realizado");
                limpar();

                dtgplantacao.DataSource = dp.Listaplantacao();

          /*  }
            catch
            {
                MessageBox.Show("Erro ao Cadastrar, por favor verifique se todos campo estão preenchidos");
            }*/

        }

        private void setfuncionario(funcionario func)

        {
            txtcodfunc.Text = func.codigo.ToString();
            txtnomefunc.Text = func.nome;

        }

        private void btnlistafunc_Click(object sender, EventArgs e)
        {
            frmlistafuncionario func = new frmlistafuncionario();
            func.ShowDialog();

            if (func.DialogResult == DialogResult.OK)
            {
                setfuncionario(func.getfuncionario());

            }
        }
    }
}
