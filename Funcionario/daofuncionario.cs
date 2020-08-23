using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Funcionario
{
    class daofuncionario
    {
        public void Cadastar(funcionario func)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("insert into farmsystem.funcionario " +
                "(nome,idade,nascimento,fone,endereco,dataadmissao,cargo,salario) " +
                "values (@nome,@idade,@dtanasc,@fone,@end,@dtaadm,@cargo,@salario)");
            query.Connection = conn.entrar();
            query.Parameters.Add("@nome", NpgsqlDbType.Varchar).Value = func.nome;
            query.Parameters.Add("@idade", NpgsqlDbType.Varchar).Value = func.idade;
            query.Parameters.Add("@dtanasc", NpgsqlDbType.Date).Value = func.datanasc;
            query.Parameters.Add("@fone", NpgsqlDbType.Varchar).Value = func.fone;
            query.Parameters.Add("@end", NpgsqlDbType.Varchar).Value = func.endereco;
            query.Parameters.Add("@dtaadm", NpgsqlDbType.Date).Value = func.dataadmissao;
            query.Parameters.Add("@cargo", NpgsqlDbType.Varchar).Value = func.cargo;
            query.Parameters.Add("@salario", NpgsqlDbType.Double).Value = func.salario;

            query.ExecuteNonQuery();
            conn.sair();
        }


        public List<funcionario> Listafuncioario()
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,nome,idade,nascimento,fone,endereco,dataadmissao,cargo,salario from farmsystem.funcionario");
            query.Connection = conn.entrar();
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<funcionario> funcionario = new List<funcionario>();
                    while (dr.Read())
                    {
                        funcionario f = new funcionario();
                        f.codigo = dr.GetInt32(0);
                        f.nome = dr.GetString(1);
                        f.idade = dr.GetString(2);
                        f.datanasc = dr.GetDateTime(3);
                        f.fone = dr.GetString(4);
                        f.endereco = dr.GetString(5);
                        f.dataadmissao = dr.GetDateTime(6);
                        f.cargo = dr.GetString(7);
                        f.salario = dr.GetDouble(8);
                        funcionario.Add(f);
                    }
                    conn.sair();
                    return funcionario;
                }
            }
            conn.sair();
            return null;
        }

        public List<funcionario> listafunciorio(String func)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("Select codigo,nome,idade,nascimento," +
                "fone,endereco,dataadmissao," +
                "cargo,salario from farmsystem.funcionario where LIKE @nomefunc");
            query.Connection = conn.entrar();
            query.Parameters.Add("@nomefunc", NpgsqlDbType.Varchar).Value = "%" + func + "%";
            using (NpgsqlDataReader dr = query.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    List<funcionario> funcionario = new List<funcionario>();
                    while (dr.Read())
                    {
                        funcionario f = new funcionario();
                        f.codigo = dr.GetInt32(0);
                        f.nome = dr.GetString(1);
                        f.idade = dr.GetString(2);
                        f.datanasc = dr.GetDateTime(3);
                        f.fone = dr.GetString(4);
                        f.endereco = dr.GetString(5);
                        f.dataadmissao = dr.GetDateTime(6);
                        f.cargo = dr.GetString(7);
                        f.salario = dr.GetFloat(8);
                        funcionario.Add(f);
                    }
                    conn.sair();
                    return funcionario;
                }
            }
            conn.sair();
            return null;
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
        public void Editar(funcionario f)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("update farmsystem.funcionario set nome=@nome," +
                " idade=@idade,nascimento=@nascimento,fone=@fone, endereco=@end, dataadmissao=@dataadmissao, " +
                "cargo=@cargo,salario=@salario where codigo=@cod");
            query.Connection = conn.entrar();
            query.Parameters.Add("@nome", NpgsqlDbType.Varchar).Value = f.nome;
            query.Parameters.Add("@end", NpgsqlDbType.Varchar).Value = f.endereco;
            query.Parameters.Add("@idade", NpgsqlDbType.Varchar).Value = f.idade;
            query.Parameters.Add("@nascimento", NpgsqlDbType.Date).Value = f.datanasc;
            query.Parameters.Add("@fone", NpgsqlDbType.Varchar).Value = f.fone;
            query.Parameters.Add("@dataadmissao", NpgsqlDbType.Date).Value = f.dataadmissao;
            query.Parameters.Add("@cargo", NpgsqlDbType.Varchar).Value = f.cargo;
            query.Parameters.Add("@salario", NpgsqlDbType.Double).Value = f.salario;
            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = f.codigo;
            query.ExecuteNonQuery();
            conn.sair();
        }

        public void Excluir(int codigo)
        {
            Conexao conn = new Conexao();
            NpgsqlCommand query = new NpgsqlCommand("delete from farmsystem.funcionario where codigo=@cod");
            query.Connection = conn.entrar();
            query.Parameters.Add("@cod", NpgsqlDbType.Integer).Value = codigo;
            query.ExecuteNonQuery();
            conn.sair();
        }




    }
}
