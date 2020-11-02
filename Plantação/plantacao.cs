using FarmSystem.Funcionario;
using FarmSystem.Produtos;
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
            daoplantacao dp = new daoplantacao();
            res = dp.getCod() + 1;
            txtcodigo.Text = res + "";
        }

        int res;

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private objplantacao GetPlantacao()
        {

            objplantacao plant = new objplantacao();

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
            plant.datadecolheita = Convert.ToDateTime(txtdatadacolheita.Text);



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
            plant.datadecolheita = Convert.ToDateTime(txtdatadacolheita.Text);


            return plant;
        }


        public objacao getAcaoPlantar()
        {
            objacao a = new objacao();

            a.tipoacao = "Plantar";
            a.plantacao = Convert.ToInt32(txtcodigo.Text);
            a.codigoprod = Convert.ToInt32(2);
            a.dataac = Convert.ToDateTime(mskdataplantio.Text);
            a.funcionario = Convert.ToInt32(txtcodfunc.Text);
            a.status = "A executar";
            a.horario = "07h00";

            return a;
        }

        public objacao getAcaoColheita()
        {
            objacao a = new objacao();

            a.tipoacao = "Colher";
            a.plantacao = Convert.ToInt32(txtcodigo.Text);
            a.codigoprod = Convert.ToInt32(2);
            a.dataac = Convert.ToDateTime(mskprevisaodata.Text);
            a.funcionario = Convert.ToInt32(txtcodfunc.Text);
            a.status = "A executar";
            a.horario = "07h00";

            return a;
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
            plant.datadecolheita = Convert.ToDateTime(dtgplantacao.CurrentRow.Cells[11].Value.ToString());


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
            txtdatadacolheita.Text = plant.datadecolheita.ToString();


        }

        private void limpar()
        {
            txtcodigo.Clear();
            txtcodfunc.Clear();
            txtnomefunc.Clear();
            txtarea.Clear();
            txtdistancia.Clear();
            //mskdataplantio.Value = DateTime.Now;
            txtvalorvenda.Clear();
            txtstatus.Text = "";
            txtprevisaosacas.Clear();
            //mskprevisaodata.Value = DateTime.Now;
            txtqtdsacas.Clear();
            txtsemente.Clear();
            //txtdatadacolheita.Value = DateTime.Now;


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

        private void cadac()
        {
            DAOacao ac = new DAOacao();

            ac.CadastarAcao(getAcaoPlantar());

            ac.CadastarAcao(getAcaoColheita());

            limpar();

        }
        private void btngravar_Click(object sender, EventArgs e)
        {
            try
            {
                daoplantacao dp = new daoplantacao();

                dp.cadastrar(GetcadPlantacao());

                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        

                atualizardtg();

                cadac();

                res = dp.getCod() + 1;
                txtcodigo.Text = res + "";


            }

        catch {
                MessageBox.Show("Não foi possível realizar o cadastro, tente novamente", "Verifique se os dados estão corretos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

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
                MessageBox.Show("Alteração efetuada com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizardtg();
                res = dp.getCod() + 1;
                txtcodigo.Text = res + "";
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar a edição, tente novamente", "Erro na edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Deseja excluir registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {

                    daoplantacao dp = new daoplantacao();
                    dp.Excluir(Convert.ToInt32(txtcodigo.Text));
                    MessageBox.Show("Excluído com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizardtg();
                    limpar();
                    res = dp.getCod() + 1;
                    txtcodigo.Text = res + "";
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir o cadastro", "Erro na exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dtgplantacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mskprevisaodata_Leave(object sender, EventArgs e)
        {

        }

        private void mskprevisaodata_ValueChanged(object sender, EventArgs e)
        {
            txtdatadacolheita.Value = mskprevisaodata.Value;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tipo = "Semente";
            Frmlistaproduto lp = new Frmlistaproduto(tipo);
            lp.ShowDialog();
        
            if (lp.DialogResult == DialogResult.OK)
            {
                Produto pd = lp.getProduto();
                txtsemente.Text = pd.nome.ToString();

            }
        }
    }
}
