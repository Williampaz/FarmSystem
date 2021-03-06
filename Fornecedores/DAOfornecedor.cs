﻿using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Fornecedores
{
	class DAOfornecedor
	{
        public void Cadastar(Fornecedor forn)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("insert into farmsystem.fornecedor (nome,telefone,endereco,cnpj,cidade,email) values (@nome,@fone,@end,@cnpj,@cid,@email)");
            query.Connection = conn.entrar();
            query.Parameters.Add("@nome", NpgsqlDbType.Varchar).Value = forn.nome;
            query.Parameters.Add("@end", NpgsqlDbType.Varchar).Value = forn.endereco;
            query.Parameters.Add("@cid", NpgsqlDbType.Varchar).Value = forn.cidade;
            query.Parameters.Add("@cnpj", NpgsqlDbType.Varchar).Value = forn.cnpj;
            query.Parameters.Add("@fone", NpgsqlDbType.Varchar).Value = forn.telefone;
            query.Parameters.Add("@email", NpgsqlDbType.Varchar).Value = forn.email;
            query.ExecuteNonQuery();
            conn.sair();
        }

        public List<Fornecedor> ListaFornecedores()
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,nome,telefone,endereco,cnpj,cidade,email from farmsystem.fornecedor");
            query.Connection = conn.entrar();
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<Fornecedor> fornecedores = new List<Fornecedor>();
                    while (dr.Read())
                    {
                        Fornecedor f = new Fornecedor();
                        f.codigo = dr.GetInt32(0);
                        f.nome = dr.GetString(1);
                        f.telefone = dr.GetString(2);
                        f.endereco = dr.GetString(3);
                        f.cnpj = dr.GetString(4);
                        f.cidade = dr.GetString(5);
                        f.email = dr.GetString(6);
                        fornecedores.Add(f);
                    }
                    conn.sair();
                    return fornecedores;
                }
            }
            conn.sair();
            return null;
        }

        public List<Fornecedor> ListaFornecedores(String forn)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,nome,telefone,endereco,cnpj,cidade,email from farmsystem.fornecedor where LIKE @nomef");
            query.Connection = conn.entrar();
            query.Parameters.Add("@nomef", NpgsqlDbType.Varchar).Value = "%" + forn + "%";
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<Fornecedor> fornecedores = new List<Fornecedor>();
                    while (dr.Read())
                    {
                        Fornecedor f = new Fornecedor();
                        f.codigo = dr.GetInt32(0);
                        f.nome = dr.GetString(1);
                        f.telefone = dr.GetString(2);
                        f.endereco = dr.GetString(3);
                        f.cnpj = dr.GetString(4);
                        f.cidade = dr.GetString(5);
                        f.email = dr.GetString(6);
                        fornecedores.Add(f);
                    }
                    conn.sair();
                    return fornecedores;
                }
            }
            conn.sair();
            return null;
        }

        public void Editar(Fornecedor f)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("update farmsystem.fornecedor set nome=@nome, telefone=@fone, endereco=@end, cnpj=@cnpj, cidade=@cid, email=@email where codigo=@cod");
            query.Connection = conn.entrar();
            query.Parameters.Add("@nome", NpgsqlDbType.Varchar).Value = f.nome;
            query.Parameters.Add("@end", NpgsqlDbType.Varchar).Value = f.endereco;
            query.Parameters.Add("@cid", NpgsqlDbType.Varchar).Value = f.cidade;
            query.Parameters.Add("@cnpj", NpgsqlDbType.Varchar).Value = f.cnpj;
            query.Parameters.Add("@fone", NpgsqlDbType.Varchar).Value = f.telefone;
            query.Parameters.Add("@email", NpgsqlDbType.Varchar).Value = f.email;
            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = f.codigo;
            query.ExecuteNonQuery();
            conn.sair();
        }
        public void Excluir(int codigo)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("delete from farmsystem.fornecedor where codigo=@cod");
            query.Connection = conn.entrar();
            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = codigo;
            query.ExecuteNonQuery();
            conn.sair();
        }

        public int getCod()
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("select f.codigo from farmsystem.fornecedor f " +
                "where f.codigo=(select max(forn.codigo) from farmsystem.fornecedor forn)");
            query.Connection = conn.entrar();
            int num = 0;
            using(NpgsqlDataReader dr = query.ExecuteReader())
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

        public Fornecedor ProcuraFornecedor(int codforn)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo, nome, telefone, endereco, cnpj, cidade, email from farmsystem.fornecedor where codigo = @cod");
            query.Connection = conn.entrar();
            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = codforn;
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    Fornecedor f = null;
                    if (dr.Read())
                    {
                        f = new Fornecedor();
                        f.codigo = dr.GetInt32(0);
                        f.nome = dr.GetString(1);
                        f.telefone = dr.GetString(2);
                        f.endereco = dr.GetString(3);
                        f.cnpj = dr.GetString(4);
                        f.cidade = dr.GetString(5);
                        f.email = dr.GetString(6);
                        
                    }
                    conn.sair();
                    return f;
                }
            }
            conn.sair();
            return null;
        }
    }
}
