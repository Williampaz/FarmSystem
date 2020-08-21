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
                "(nome,idade,datadenascimento,telefone,endereco,datadeadmissao,cargo,salario) " +
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





    }
}
