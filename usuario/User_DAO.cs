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
        public void cadastrar(string nome, string rg, string cpf,DateTime nascimento, string idade, string email, string senha, string endereco,String cidade)
		{
            NpgsqlCommand query = new NpgsqlCommand("insert into farmsystem.usuario (nome, rg, cpf, nascimento, idade, email, senha, endereco,cidade) " +
                                                                         "values (@nome, @rg, @cpf, @nascimento, @idade, @email, @senha, @endereco, @cidade)");
            query.Connection = conn.entrar();
            query.Parameters.Add("@nome", NpgsqlDbType.Varchar).Value = nome;
            query.Parameters.Add("@rg", NpgsqlDbType.Varchar).Value = rg;
            query.Parameters.Add("@cpf", NpgsqlDbType.Varchar).Value = cpf;
            query.Parameters.Add("@nascimento", NpgsqlDbType.Date).Value = nascimento;
            query.Parameters.Add("@idade", NpgsqlDbType.Varchar).Value = idade;
            query.Parameters.Add("@email", NpgsqlDbType.Varchar).Value = email;
            query.Parameters.Add("@senha", NpgsqlDbType.Varchar).Value = senha;
            query.Parameters.Add("@endereco", NpgsqlDbType.Varchar).Value = endereco;
            query.Parameters.Add("@cidade", NpgsqlDbType.Varchar).Value = cidade;

            query.ExecuteNonQuery();
            conn.sair();
		}
        public void editar(User user)
		{
            NpgsqlCommand query = new NpgsqlCommand("update farmsystem.usuario set nome = @nome, rg = @rg, cpf = @cpf, " +
                "nascimento = @nascimento, idade = @idade, email = @email, senha = @senha, endereco = @endereco, cidade = @cidade where codigo = @codigo");
            query.Connection = conn.entrar();
            query.Parameters.Add("@codigo", NpgsqlDbType.Integer).Value = user.codigo;
            query.Parameters.Add("@nome", NpgsqlDbType.Varchar).Value = user.nome;
            query.Parameters.Add("@rg", NpgsqlDbType.Varchar).Value = user.rg;
            query.Parameters.Add("@cpf", NpgsqlDbType.Varchar).Value = user.cpf;
            query.Parameters.Add("@nascimento", NpgsqlDbType.Date).Value = user.nascimento;
            query.Parameters.Add("@idade", NpgsqlDbType.Varchar).Value = user.idade;
            query.Parameters.Add("@email", NpgsqlDbType.Varchar).Value = user.email;
            query.Parameters.Add("@senha", NpgsqlDbType.Varchar).Value = user.senha;
            query.Parameters.Add("@endereco", NpgsqlDbType.Varchar).Value = user.endereco;
            query.Parameters.Add("@cidade", NpgsqlDbType.Varchar).Value = user.cidade;
            query.ExecuteNonQuery();
            conn.sair();
        }
        public void deletar(int codigo)
		{
            NpgsqlCommand query = new NpgsqlCommand("delete farmsystem.usuario where codigo = @codigo");
            query.Connection = conn.entrar();
            query.Parameters.Add("@codigo", NpgsqlDbType.Integer).Value = codigo;
            query.ExecuteNonQuery();
            conn.sair();
        }
        public List<User> bustatodos()
        {
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
        public List<User> bustaUsuarios()
        {
            NpgsqlCommand query = new NpgsqlCommand(
                "Select codigo, nome, rg, cpf, nascimento, idade, email, senha, endereco, cidade from farmsystem.usuario");
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
                        user.nome = rs.GetString(1);
                        user.rg = rs.GetString(2);
                        user.cpf = rs.GetString(3);
                        user.nascimento = rs.GetDateTime(4);
                        user.idade = rs.GetString(5);
                        user.email = rs.GetString(6);
                        user.senha = rs.GetString(7);
                        user.endereco = rs.GetString(8);
                        user.cidade = rs.GetString(9);

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