using FarmSystem.Funcionario;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Plantação
{
    class daoplantacao
    {

        public void cadastrar (objplantacao plant)
        {
   
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("insert into farmsystem.plantacao" +
                "(funcionario,area,distinciaentreplantas, datadeplantio, valordevenda, statusdaplantacao, " +
                "previsaodecolheita, prevdatacolheita,quantidadecolhida, sementeusada)" +
                "values(@funcionario, @area, @distanciaentreplantas, @datadeplantio, @valordevenda, @status," +
                "@previsaocolheita, @prevdatacolheita, @quantidadecolhida, @semente)");

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

            query.Connection = conn.entrar();
            query.Parameters.Add("@funcionario", NpgsqlDbType.Integer).Value = plant.funcionario;
            query.Parameters.Add("@area", NpgsqlDbType.Double).Value = plant.area;
            query.Parameters.Add("@distanciaentreplantas", NpgsqlDbType.Double).Value = plant.distinciaentreplantas;
            query.Parameters.Add("@datadeplantio", NpgsqlDbType.Date).Value = plant.datadeplantio;
            query.Parameters.Add("@valordevenda", NpgsqlDbType.Varchar).Value = plant.valordevenda;
            query.Parameters.Add("@status", NpgsqlDbType.Varchar).Value = plant.statusdaplantacao;
            query.Parameters.Add("@previsaocolheita", NpgsqlDbType.Integer).Value = plant.previsaodecolheita;
            query.Parameters.Add("@prevdatacolheita", NpgsqlDbType.Date).Value = plant.prevdatacolheita;
            query.Parameters.Add("@quantidadecolhida", NpgsqlDbType.Integer).Value = plant.quantidadecolhida;
            query.Parameters.Add("@semente", NpgsqlDbType.Varchar).Value = plant.sementeusada;

            query.ExecuteNonQuery();
            conn.sair();

        }

        public List<objplantacao> Listaplantacao()
        {
            Conexao conn = new Conexao();
          NpgsqlCommand query = new NpgsqlCommand("Select codigo,funcionario, area, distinciaentreplantas, datadeplantio, valordevenda,statusdaplantacao,previsaodecolheita, prevdatacolheita, quantidadecolhida,sementeusada from Farmsystem.plantacao");

            query.Connection = conn.entrar();
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<objplantacao> plantacao = new List<objplantacao>();
                    while (dr.Read())
                    {
                        objplantacao p = new objplantacao();

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

                       plantacao.Add(p);
                    }
                    conn.sair();
                    return plantacao;
                }
            }
            conn.sair();
            return null;
        }


        public List<objplantacao> Listaplantacao(String semente)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,funcionario,area, distinciaentreplantas, datadeplantio,valordevenda,statusdaplantacao,previsaodecolheita, prevdatacolheita, quantidadecolhida,sementeusada from farmsystem.plantacao where sementeusada ILIKE @semente");

            query.Connection = conn.entrar();

            query.Parameters.Add("@semente", NpgsqlDbType.Varchar).Value = "%" + semente + "%";

            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<objplantacao> plantacao = new List<objplantacao>();
                    while (dr.Read())
                    {
                        objplantacao p = new objplantacao();

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

                        plantacao.Add(p);
                    }
                    conn.sair();
                    return plantacao;
                }
            }
            conn.sair();
            return null;
        }


        public void Editar(objplantacao plant)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("update farmsystem.plantacao set funcionario = @funcionario," +
                " area = @area,distinciaentreplantas = @distinciaentreplantas,datadeplantio = @datadeplantio, " +
                "valordevenda = @valordevenda, statusdaplantacao = @status, previsaodecolheita = @previsaodecolheita," +
                "prevdatacolheita = @prevdatacolheita,quantidadecolhida = @quantidadecolhida,sementeusada = @sementeusada" +
                " where codigo = @cod");
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


            query.Connection = conn.entrar();

            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = plant.codigo;
            query.Parameters.Add("@funcionario", NpgsqlDbType.Integer).Value = plant.funcionario;
            query.Parameters.Add("@area", NpgsqlDbType.Double).Value = plant.area;
            query.Parameters.Add("@distinciaentreplantas", NpgsqlDbType.Double).Value = plant.distinciaentreplantas;
            query.Parameters.Add("@datadeplantio", NpgsqlDbType.Date).Value = plant.datadeplantio;
            query.Parameters.Add("@valordevenda", NpgsqlDbType.Varchar).Value = plant.valordevenda;
            query.Parameters.Add("@status", NpgsqlDbType.Varchar).Value = plant.statusdaplantacao;
            query.Parameters.Add("@previsaocolheita", NpgsqlDbType.Integer).Value = plant.previsaodecolheita;
            query.Parameters.Add("@prevdatacolheita", NpgsqlDbType.Date).Value = plant.prevdatacolheita;
            query.Parameters.Add("@quantidadecolhida", NpgsqlDbType.Integer).Value = plant.quantidadecolhida;
            query.Parameters.Add("@sementeusada", NpgsqlDbType.Varchar).Value = plant.sementeusada;

            query.ExecuteNonQuery();
            conn.sair();
        }

        public funcionario buscafuncid(int codfunc)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,nome,idade,nascimento," +
                "fone,endereco,dataadmissao," +
                "cargo,salario from farmsystem.funcionario where codigo = @codfunc");
            query.Connection = conn.entrar();
            query.Parameters.Add("@codfunc", NpgsqlDbType.Integer).Value = codfunc;

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

        public void Excluir(int codigo)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("delete from farmsystem.plantacao where codigo=@cod");
            query.Connection = conn.entrar();
            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = codigo;
            query.ExecuteNonQuery();
            conn.sair();
        }




    }



}
