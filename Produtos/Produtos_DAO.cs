using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Produtos
{
	class Produtos_DAO
	{
        public void Cadastar(Produto prod)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("insert into farmsystem.produtos (codigo,nome,quantidade,tipoprod,mesdeuso,validade,mesdeplantio,diacolheita,preçokg_uni,descricao) values (@cod,@nome,@quantidade,@tipoprod,@mesdeuso,@validade,@mesdeplantio,@diacolheita,@preçokg_uni,@descricao)");
            query.Connection = conn.entrar();
            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = prod.codigo;
            query.Parameters.Add("@nome", NpgsqlDbType.Varchar).Value = prod.nome;
            query.Parameters.Add("@quantidade", NpgsqlDbType.Integer).Value = prod.quantidade;
            query.Parameters.Add("@tipoprod", NpgsqlDbType.Varchar).Value = prod.tipoprod;
            query.Parameters.Add("@mesdeuso", NpgsqlDbType.Varchar).Value = prod.mesdeuso;
            query.Parameters.Add("@validade", NpgsqlDbType.Varchar).Value = prod.validade;
            query.Parameters.Add("@mesdeplantio", NpgsqlDbType.Varchar).Value = prod.mesdeplantio;
            query.Parameters.Add("@diacolheita", NpgsqlDbType.Varchar).Value = prod.diacolheita;
            query.Parameters.Add("@preçokg_uni", NpgsqlDbType.Varchar).Value = prod.preçokg_uni;
            query.Parameters.Add("@descricao", NpgsqlDbType.Varchar).Value = prod.descricao;
            query.ExecuteNonQuery();
            conn.sair();
        }

        public List<Produto> ListaProduto()
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,nome,quantidade,tipoprod,mesdeuso,validade,mesdeplantio,diacolheita,preçokg_uni,descricao from farmsystem.produtos");
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
                        p.nome = dr.GetString(1);
                        p.quantidade = dr.GetInt32(2);
                        p.tipoprod = dr.GetString(3);
                        p.mesdeuso = dr.GetString(4);
                        p.validade = dr.GetDateTime(5);
                        p.mesdeplantio = dr.GetDateTime(6);
                        p.diacolheita = dr.GetInt32(7);
                        p.preçokg_uni = dr.GetInt32(8);
                        p.descricao = dr.GetString(9);
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
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,nome,quantidade,tipoprod,mesdeuso,validade,mesdeplantio,diacolheita,preçokg_uni,descricao from farmsystem.produtos where LIKE @nomep");
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
                        p.nome = dr.GetString(1);
                        p.quantidade = dr.GetInt32(2);
                        p.tipoprod = dr.GetString(3);
                        p.mesdeuso = dr.GetString(4);
                        p.validade = dr.GetDateTime(5);
                        p.mesdeplantio = dr.GetDateTime(6);
                        p.diacolheita = dr.GetInt32(7);
                        p.preçokg_uni = dr.GetInt32(8);
                        p.descricao = dr.GetString(9);
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
            NpgsqlCommand query = new NpgsqlCommand("update farmsystem.produtos set nome=@nome, quantidade=@quantidade, tipoprod=@tipoprod, mesdeuso=@mesdeuso, mesdeplantio=@mesdeplantio, diacolheita=@diacolheita,preçokg_uni@preçokg_uni,descricao@descricao where codigo=@cod");
            query.Connection = conn.entrar();
            query.Parameters.Add("@nome", NpgsqlDbType.Varchar).Value = p.nome;
            query.Parameters.Add("@quantidade", NpgsqlDbType.Varchar).Value = p.quantidade;
            query.Parameters.Add("@tipoprod", NpgsqlDbType.Varchar).Value = p.tipoprod;
            query.Parameters.Add("@mesdeuso", NpgsqlDbType.Varchar).Value = p.mesdeuso;
            query.Parameters.Add("@mesdeplantio", NpgsqlDbType.Varchar).Value = p.mesdeplantio;
            query.Parameters.Add("@diacolheita", NpgsqlDbType.Varchar).Value = p.diacolheita;
            query.Parameters.Add("@preçokg_uni", NpgsqlDbType.Varchar).Value = p.preçokg_uni;
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
    }
}
