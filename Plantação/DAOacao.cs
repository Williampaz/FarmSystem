using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmSystem.Funcionario;
using FarmSystem.Plantação;
using FarmSystem.Produtos;
using Npgsql;
using NpgsqlTypes;

namespace FarmSystem
{
    class DAOacao
    {
        public void CadastarAcao(objacao acao)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("insert into farmsystem.acoes (tipoacao,plantacao," +
                "codigoprod,dataac,funcionario,status,horario) values (@tipo,@plantacao,@prod,@dt,@func,@status,@horario)");
            query.Connection = conn.entrar();
            query.Parameters.Add("@tipo", NpgsqlDbType.Varchar).Value = acao.tipoacao;
            query.Parameters.Add("@plantacao", NpgsqlDbType.Integer).Value = acao.plantacao;
            query.Parameters.Add("@prod", NpgsqlDbType.Integer).Value = acao.codigoprod;
            query.Parameters.Add("@dt", NpgsqlDbType.Date).Value = acao.dataac;
            query.Parameters.Add("@func", NpgsqlDbType.Integer).Value = acao.funcionario;
            query.Parameters.Add("@status", NpgsqlDbType.Varchar).Value = acao.status;
            query.Parameters.Add("@horario", NpgsqlDbType.Varchar).Value = acao.horario;

            query.ExecuteNonQuery();
            conn.sair();
        }

        public List<objacao> ListaAcoes()
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,tipoacao,plantacao,codigoprod,dataac,funcionario,status,horario from farmsystem.acoes");
            query.Connection = conn.entrar();
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<objacao> acoes = new List<objacao>();
                    while (dr.Read())
                    {
                        objacao ac = new objacao();
                        ac.codigo = dr.GetInt32(0);
                        ac.tipoacao = dr.GetString(1);
                        ac.plantacao = dr.GetInt32(2);
                        ac.codigoprod = dr.GetInt32(3);
                        ac.dataac = dr.GetDateTime(4);
                        ac.funcionario = dr.GetInt32(5);
                        ac.status = dr.GetString(6);
                        ac.horario = dr.GetString(7);

                        acoes.Add(ac);
                    }
                    conn.sair();
                    return acoes;
                }
            }
            conn.sair();
            return null;
        }

        public int getCod()
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("select a.codigo from farmsystem.acoes a " +
                "where a.codigo=(select max(ac.codigo) from farmsystem.acoes ac)");
            query.Connection = conn.entrar();
            int num = 0;
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        num = dr.GetInt32(0);
                    }
                    conn.sair();
                    return num;
                }
            }
            conn.sair();
            return num;
        }

        public void EditarAcao(objacao a)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("update farmsystem.acoes set " +
                "tipoacao=@tipo, plantacao=@plant, codigoprod=@prod, dataac=@dt," +
                " funcionario=@func, status=@status, horario = @horario where codigo=@cod");
            query.Connection = conn.entrar();
            query.Parameters.Add("@tipo", NpgsqlDbType.Varchar).Value = a.tipoacao;
            query.Parameters.Add("@plant", NpgsqlDbType.Integer).Value = a.plantacao;
            query.Parameters.Add("@prod", NpgsqlDbType.Integer).Value = a.codigoprod;
            query.Parameters.Add("@dt", NpgsqlDbType.Date).Value = a.dataac;
            query.Parameters.Add("@func", NpgsqlDbType.Integer).Value = a.funcionario;
            query.Parameters.Add("@status", NpgsqlDbType.Varchar).Value = a.status;
            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = a.codigo;
            query.Parameters.Add("@horario", NpgsqlDbType.Varchar).Value = a.horario;
            query.ExecuteNonQuery();
            conn.sair();
        }

        public void ExcluirAcao(int codigo)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("delete from farmsystem.acoes where codigo=@cod");
            query.Connection = conn.entrar();
            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = codigo;
            query.ExecuteNonQuery();
            conn.sair();
        }

        public List<objacao> ListaAcoes(String acao)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,tipoacao,plantacao,codigoprod,dataac,funcionario,status, horario from farmsystem.acoes where LIKE @acao");
            query.Parameters.Add("@acao", NpgsqlDbType.Varchar).Value = "%" + acao + "%";
            query.Connection = conn.entrar();
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<objacao> acoes = new List<objacao>();
                    while (dr.Read())
                    {
                        objacao ac = new objacao();
                        ac.codigo = dr.GetInt32(0);
                        ac.tipoacao = dr.GetString(1);
                        ac.plantacao = dr.GetInt32(2);
                        ac.codigoprod = dr.GetInt32(3);
                        ac.dataac = dr.GetDateTime(4);
                        ac.funcionario = dr.GetInt32(5);
                        ac.status = dr.GetString(6);
                        ac.horario = dr.GetString(7);

                        acoes.Add(ac);
                    }
                    conn.sair();
                    return acoes;
                }
            }
            conn.sair();
            return null;
        }

        public funcionario ProcuraFuncionario(int codFunc)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,nome,idade,nascimento,fone,endereco,dataadmissao,cargo,salario from farmsystem.funcionario where codigo = @codfunc");
            query.Connection = conn.entrar();
            query.Parameters.Add("@codfunc", NpgsqlDbType.Integer).Value = codFunc;
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    funcionario f = null;
                    if (dr.Read())
                    {
                        f = new funcionario();
                        f.codigo = dr.GetInt32(0);
                        f.nome = dr.GetString(1);
                        f.idade = dr.GetString(2);
                        f.datanasc = dr.GetDateTime(3);
                        f.fone = dr.GetString(4);
                        f.endereco = dr.GetString(5);
                        f.dataadmissao = dr.GetDateTime(6);
                        f.cargo = dr.GetString(7);
                        f.salario = dr.GetDouble(8);
                    }
                    conn.sair();
                    return f;
                }
            }
            conn.sair();
            return null;
        }

        public Produto ProcuraProduto(int codProd)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,codigoforn,tipoprod,nome,quantidade,mesdeuso,validade,mesdeplantio,diacolheita,precokg_uni,descricao from farmsystem.produtos where codigo = @cod");
            query.Connection = conn.entrar();
            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = codProd;
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    Produto p = null;
                    if (dr.Read())
                    {
                        p = new Produto();
                        p.codigo = dr.GetInt32(0);
                        p.codigoforn = dr.GetInt32(1);
                        p.tipoprod = dr.GetString(2);
                        p.nome = dr.GetString(3);
                        p.quantidade = dr.GetInt32(4);
                        p.mesdeuso = dr.GetString(5);
                        p.validade = dr.GetDateTime(6);
                        p.mesdeplantio = dr.GetDateTime(7);
                        p.diacolheita = dr.GetInt32(8);
                        p.precokg_uni = dr.GetDouble(9);
                        p.descricao = dr.GetString(10);
                    }
                    conn.sair();
                    return p;
                }
            }
            conn.sair();
            return null;
        }

        public objplantacao ProcuraPlantacao(int codPlant)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,funcionario,area,distinciaentreplantas,datadeplantio,valordevenda,statusdaplantacao,previsaodecolheita,prevdatacolheita,quantidadecolhida,sementeusada from farmsystem.plantacao where codigo = @cod");
            query.Connection = conn.entrar();
            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = codPlant;
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    objplantacao p = null;
                    if (dr.Read())
                    {
                        p = new objplantacao();
                        p.codigo = dr.GetInt32(0);
                        p.funcionario = dr.GetInt32(1);
                        p.area = dr.GetDouble(2);
                        p.distinciaentreplantas = dr.GetDouble(3);
                        p.datadeplantio = dr.GetDateTime(4);
                        p.valordevenda = dr.GetString(5);
                        p.statusdaplantacao = dr.GetString(6);
                        p.previsaodecolheita = dr.GetInt32(7);
                        p.prevdatacolheita = dr.GetDateTime(8);
                        p.quantidadecolhida = dr.GetInt32(9);
                        p.sementeusada = dr.GetString(10);
                    }
                    conn.sair();
                    return p;
                }
            }
            conn.sair();
            return null;
        }
        public List<Data_Acao> Lista_Data(DateTime data)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("SELECT p2.codigo, p2.sementeusada, p.nome, f.nome, a.dataac, a.tipoacao, a.status, a.horario FROM farmsystem.acoes a, farmsystem.produtos p, farmsystem.plantacao p2, farmsystem.funcionario f where a.plantacao = p2.codigo and f.codigo = a.funcionario and a.codigoprod = p.codigo and a.dataac = @data order by a.dataac, a.codigo");
            query.Parameters.Add("@data", NpgsqlDbType.Date).Value = data;
            query.Connection = conn.entrar();
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<Data_Acao> acoes = new List<Data_Acao>();
                    while (dr.Read())
                    {
                        Data_Acao ac = new Data_Acao();
                        ac.codigo = dr.GetInt32(0);
                        ac.semente_usada = dr.GetString(1);
                        ac.nome_produto = dr.GetString(2);
                        ac.nome_funcionario = dr.GetString(3);
                        ac.data_acao = dr.GetDateTime(4);
                        ac.Tipo_Acao = dr.GetString(5);
                        ac.Status = dr.GetString(6);
                        ac.Horario = dr.GetString(7);

                        acoes.Add(ac);
                    }
                    conn.sair();
                    return acoes;
                }
            }
            conn.sair();
            return null;
        }
    }
}
