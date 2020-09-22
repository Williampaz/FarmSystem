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

            plant.codigo = Convert.ToInt32(txtcodigo.Text);
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

        private objplantacao GetcadPlantacao()
        {

            objplantacao plant = new objplantacao();


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



        private objplantacao getlistplantacao()
        {
            objplantacao plant = new objplantacao();

            plant.codigo = Convert.ToInt32(dtgplantacao.CurrentRow.Cells[0].Value.ToString());
            plant.funcionario = Convert.ToInt32(dtgplantacao.CurrentRow.Cells[1].Value.ToString());
            plant.area = Convert.ToDouble(dtgplantacao.CurrentRow.Cells[2].Value.ToString());
            plant.distinciaentreplantas = Convert.ToDouble(dtgplantacao.CurrentRow.Cells[3].Value.ToString());
            plant.datadeplantio = Convert.ToDateTime(dtgplantacao.CurrentRow.Cells[4].Value.ToString());
            plant.valordevenda = dtgplantacao.CurrentRow.Cells[5].Value.ToString();
            plant.statusdaplantacao = dtgplantacao.CurrentRow.Cells[6].Value.ToString();
            plant.previsaodecolheita = Convert.ToInt32(dtgplantacao.CurrentRow.Cells[7].Value.ToString());
            plant.prevdatacolheita = Convert.ToDateTime(dtgplantacao.CurrentRow.Cells[8].Value.ToString());
            plant.quantidadecolhida = Convert.ToInt32(dtgplantacao.CurrentRow.Cells[9].Value.ToString());
            plant.sementeusada = dtgplantacao.CurrentRow.Cells[10].Value.ToString();

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

        private void atualizardtg()
        {
            daoplantacao dp = new daoplantacao();
            dtgplantacao.DataSource = dp.Listaplantacao();

        }
        private void plantacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'postgresDataSet2.plantacao'. Você pode movê-la ou removê-la conforme necessário.
            this.plantacaoTableAdapter.Fill(this.postgresDataSet2.plantacao);

            atualizardtg();
            

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

                dp.cadastrar(GetcadPlantacao());

                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro Realizado");
                limpar();

            atualizardtg();

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

        private void dtgplantacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            setplantacao(getlistplantacao());
               
           
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                daoplantacao dp = new daoplantacao();
                dp.Editar(GetPlantacao());
                limpar();
                MessageBox.Show("Alteração efetuada com sucesso!", "Alteração");
                atualizardtg();
            }
            catch
            {
                MessageBox.Show("Erro por favor verifique se algum campo esta em branco", "Erro");
            }
        }

        private void brnexcluir_Click(object sender, EventArgs e)
        {

            DialogResult confirm = MessageBox.Show("Deseja excluir registro?","Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES") {

                daoplantacao dp = new daoplantacao();
                dp.Excluir(Convert.ToInt32(txtcodigo.Text));
                MessageBox.Show("Excluido", "Exclusão");
                atualizardtg();
                limpar();
            }
        }

        private void txtcodfunc_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;
            if ((txt.Name == txtcodfunc.Name) && (txt.Text != ""))
            {
                funcionario f = new daoplantacao().buscafuncid(Int32.Parse(txtcodfunc.Text));


                if (f != null)
                {
                    setfuncionario(f);
                }
            }
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
        
            daoplantacao dp = new daoplantacao();
            dtgplantacao.DataSource = dp.Listaplantacao(txtpesquisa.Text);
        
        }
    }
}
