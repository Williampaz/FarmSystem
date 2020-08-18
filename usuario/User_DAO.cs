using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.usuario
{
	class User_DAO
	{
        Conexao conn = new Conexao();

        private Boolean existe = false;
        public Boolean logar(String email, String senha)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand(
                "Select email, senha from farmsystem.usuario where email = @email and senha = @senha");
            query.Connection = conn.entrar();
            query.Parameters.AddWithValue("@email", NpgsqlDbType.Text).Value = email;
            query.Parameters.AddWithValue("@senha", NpgsqlDbType.Text).Value = senha;
            using (NpgsqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    User usuario = null;
                    if (rs.Read())
                    {
                        usuario = new User();
                        usuario.email= rs.GetString(0);
                        usuario.senha = rs.GetString(1);
                        existe = true;
                    }
                    conn.sair();
                    return existe;
                }
                else
                {
                    existe = false;
                }
            }
            conn.sair();
            return existe;
        }
        public void cadastrar(string nome, string rg, string cpf,DateTime nascimento, string idade, string email, string senha, string endereco)
		{
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("insert into farmsystem.usuario (nome, rg, cpf, nascimento, idade, email, senha, endereco) " +
                                                                         "values (@nome, @rg, @cpf, @nascimento, @idade, @email, @senha, @endereco)");
            query.Connection = conn.entrar();
            query.Parameters.Add("@nome", NpgsqlDbType.Varchar).Value = nome;
            query.Parameters.Add("@rg", NpgsqlDbType.Varchar).Value = rg;
            query.Parameters.Add("@cpf", NpgsqlDbType.Varchar).Value = cpf;
            query.Parameters.Add("@nascimento", NpgsqlDbType.Date).Value = nascimento;
            query.Parameters.Add("@idade", NpgsqlDbType.Varchar).Value = idade;
            query.Parameters.Add("@email", NpgsqlDbType.Varchar).Value = email;
            query.Parameters.Add("@senha", NpgsqlDbType.Varchar).Value = senha;
            query.Parameters.Add("@endereco", NpgsqlDbType.Varchar).Value = endereco;
            query.ExecuteNonQuery();
            conn.sair();
		}
        public void editar(int codigo, string nome, string rg, string cpf, DateTime nascimento, string idade, string email, string senha, string endereco)
		{
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("update farmsystem.usuario set nome = @nome, rg = @rg, cpf = @cpf, " +
                "nascimento = @nascimento, idade = @idade, email = @email, senha = @senha, endereço = @endereco where codigo = @codigo");
            query.Connection = conn.entrar();
            query.Parameters.Add("@codigo", NpgsqlDbType.Integer).Value = codigo;
            query.Parameters.Add("@nome", NpgsqlDbType.Varchar).Value = nome;
            query.Parameters.Add("@rg", NpgsqlDbType.Varchar).Value = rg;
            query.Parameters.Add("@cpf", NpgsqlDbType.Varchar).Value = cpf;
            query.Parameters.Add("@nascimento", NpgsqlDbType.Date).Value = nascimento;
            query.Parameters.Add("@idade", NpgsqlDbType.Varchar).Value = idade;
            query.Parameters.Add("@email", NpgsqlDbType.Varchar).Value = email;
            query.Parameters.Add("@senha", NpgsqlDbType.Varchar).Value = senha;
            query.Parameters.Add("@endereco", NpgsqlDbType.Varchar).Value = endereco;
            query.ExecuteNonQuery();
            conn.sair();
        }
        public void deletar(int codigo)
		{
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("delete farmsystem.usuario where codigo = @codigo");
            query.Connection = conn.entrar();
            query.Parameters.Add("@codigo", NpgsqlDbType.Integer).Value = codigo;
            query.ExecuteNonQuery();
            conn.sair();
        }
        public List<User> bustatodos()
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand(
                "Select codigo from farmsystem.usuario");
            query.Connection = conn.entrar();
            using (NpgsqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<User> users = new List<User>();
                    while (rs.Read())
                    {
                        User user = new User();
                        user.codigo = rs.GetInt32(0);
                        users.Add(user);
                    }
                    conn.sair();
                    return users;
                }
            }
            conn.sair();
            return null;
        }
    }
}