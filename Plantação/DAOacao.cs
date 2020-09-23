using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmSystem.Plantação;
using Npgsql;
using NpgsqlTypes;

namespace FarmSystem
{
    class DAOacao
    {
        public void CadastarAcao(objacao acao)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("insert into farmsystem.acoes (tipoacao,plantacao,codigoprod,dataac,funcionario,status) values (@tipo,@plantacao,@prod,@dt,@func,@status)");
            query.Connection = conn.entrar();
            query.Parameters.Add("@tipo", NpgsqlDbType.Varchar).Value = acao.tipoacao;
            query.Parameters.Add("@plantacao", NpgsqlDbType.Integer).Value = acao.plantacao;
            query.Parameters.Add("@prod", NpgsqlDbType.Integer).Value = acao.codigoprod;
            query.Parameters.Add("@dt", NpgsqlDbType.Date).Value = acao.dataac;
            query.Parameters.Add("@func", NpgsqlDbType.Integer).Value = acao.funcionario;
            query.Parameters.Add("@status", NpgsqlDbType.Varchar).Value = acao.status;
            query.ExecuteNonQuery();
            conn.sair();
        }

        public List<objacao> ListaAcoes()
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,tipoacao,plantacao,codigoprod,dataac,funcionario,status from farmsystem.acoes");
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
                " funcionario=@func, status=@status where codigo=@cod");
            query.Connection = conn.entrar();
            query.Parameters.Add("@tipo", NpgsqlDbType.Varchar).Value = a.tipoacao;
            query.Parameters.Add("@plant", NpgsqlDbType.Integer).Value = a.plantacao;
            query.Parameters.Add("@prod", NpgsqlDbType.Integer).Value = a.codigoprod;
            query.Parameters.Add("@dt", NpgsqlDbType.Date).Value = a.dataac;
            query.Parameters.Add("@func", NpgsqlDbType.Integer).Value = a.funcionario;
            query.Parameters.Add("@status", NpgsqlDbType.Varchar).Value = a.status;
            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = a.codigo;
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
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,tipoacao,plantacao,codigoprod,dataac,funcionario,status from farmsystem.acoes where LIKE @acao");
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
