using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Produtos
{
	class Produtos_DAO
	{
        public void Cadastar(int codigoforn, string nome, int quantidade, string tipoprod, String mesdeuso, DateTime validade, DateTime mesdeplantio, int diacolheita, double precokg_uni, string descricao)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("insert into farmsystem.produtos (codigoforn,nome,quantidade,tipoprod,mesdeuso,validade,mesdeplantio,diacolheita,precokg_uni,descricao) values (@codforn,@nome,@quantidade,@tipoprod,@mesdeuso,@validade,@mesdeplantio,@diacolheita,@precokg_uni,@descricao)");
            query.Connection = conn.entrar();
            Produto p = new Produto();
            query.Parameters.Add("@codforn", NpgsqlDbType.Integer).Value = codigoforn;
            query.Parameters.Add("@nome", NpgsqlDbType.Varchar).Value = nome;
            query.Parameters.Add("@quantidade", NpgsqlDbType.Integer).Value = quantidade;
            query.Parameters.Add("@tipoprod", NpgsqlDbType.Varchar).Value = tipoprod;
            query.Parameters.Add("@mesdeuso", NpgsqlDbType.Varchar).Value = mesdeuso;
            query.Parameters.Add("@validade", NpgsqlDbType.Date).Value = validade;
            query.Parameters.Add("@mesdeplantio", NpgsqlDbType.Date).Value = mesdeplantio;
            query.Parameters.Add("@diacolheita", NpgsqlDbType.Integer).Value = diacolheita;
            query.Parameters.Add("@precokg_uni", NpgsqlDbType.Double).Value = precokg_uni;
            query.Parameters.Add("@descricao", NpgsqlDbType.Varchar).Value = descricao;
            query.ExecuteNonQuery();
            conn.sair();
        }

        public List<Produto> ListaProduto()
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,codigoforn,nome,quantidade,tipoprod,mesdeuso,validade,mesdeplantio,diacolheita,precokg_uni,descricao from farmsystem.produtos");
            query.Connection = conn.entrar();
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<Produto> produtos = new List<Produto>();
                    while (dr.Read())
                    {
                        Produto p = new Produto();
                        p.codigo = dr.GetInt32(0);
                        p.codigoforn = dr.GetInt32(1);
                        p.nome = dr.GetString(2);
                        p.quantidade = dr.GetInt32(3);
                        p.tipoprod = dr.GetString(4);
                        p.mesdeuso = dr.GetString(5);
                        p.validade = dr.GetDateTime(6);
                        p.mesdeplantio = dr.GetDateTime(7);
                        p.diacolheita = dr.GetInt32(8);
                        p.precokg_uni = dr.GetDouble(9);
                        p.descricao = dr.GetString(10);
                        produtos.Add(p);
                    }
                    conn.sair();
                    return produtos;
                }
            }
            conn.sair();
            return null;
        }

        public List<Produto> ListaProduto(String prod)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,codigoforn,tipoprod,nome,quantidade,mesdeuso,validade," +
                "mesdeplantio,diacolheita,precokg_uni,descricao from farmsystem.produtos where nome ILIKE @nomep");
            query.Connection = conn.entrar();
            query.Parameters.Add("@nomep", NpgsqlDbType.Varchar).Value = "%" + prod + "%";
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<Produto> produtos = new List<Produto>();
                    while (dr.Read())
                    {
                        Produto p = new Produto();
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
                        produtos.Add(p);
                    }
                    conn.sair();
                    return produtos;
                }
            }
            conn.sair();
            return null;
        }

        public void Editar(Produto p)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("update farmsystem.produtos set " +
                "codigoforn = @codforn," +
                " nome=@nome," +
                " quantidade=@quantidade," +
                " tipoprod=@tipoprod, " +
                "mesdeuso= @mesdeuso," +
                "validade = @validade, " +
                "mesdeplantio= @mesdeplantio," +
                " diacolheita= @diacolheita," +
                "precokg_uni = @precokg_uni," +
                "descricao = @descricao where codigo=@cod");

            query.Connection = conn.entrar();
           
            query.Parameters.Add("@nome", NpgsqlDbType.Varchar).Value = p.nome;
            query.Parameters.Add("@codforn", NpgsqlDbType.Integer).Value = p.codigoforn;
            query.Parameters.Add("@quantidade", NpgsqlDbType.Integer).Value = p.quantidade;
            query.Parameters.Add("@tipoprod", NpgsqlDbType.Varchar).Value = p.tipoprod;
            query.Parameters.Add("@mesdeuso", NpgsqlDbType.Varchar).Value = p.mesdeuso;
            query.Parameters.Add("@mesdeplantio", NpgsqlDbType.Date).Value = p.mesdeplantio;
            query.Parameters.Add("@validade", NpgsqlDbType.Date).Value = p.validade;
            query.Parameters.Add("@diacolheita", NpgsqlDbType.Integer).Value = p.diacolheita;
            query.Parameters.Add("@precokg_uni", NpgsqlDbType.Double).Value = p.precokg_uni;
            query.Parameters.Add("@descricao", NpgsqlDbType.Varchar).Value = p.descricao;
            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = p.codigo;

            query.ExecuteNonQuery();
            conn.sair();
        }

        public void Excluir(Produto p)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("delete from farmsystem.produtos where codigo=@cod");
            query.Connection = conn.entrar();
            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = p.codigo;
            query.ExecuteNonQuery();
            conn.sair();
        }

        public int getCod()
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("select p.codigo from farmsystem.produtos p " +
                "where p.codigo=(select max(prod.codigo) from farmsystem.produtos prod)");
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

    }
}
