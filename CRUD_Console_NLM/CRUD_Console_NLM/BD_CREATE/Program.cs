using System;
using System.Data.OleDb;

namespace BD_CREATE
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection conexao = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0;
                                                            Data Source = C:\Users\Técnico\Desktop\Nicolas\DB_Escola.mdb");

            Console.WriteLine("Digite o nome do aluno que será cadastrado: ");
            string nomeAluno = Console.ReadLine();

            OleDbCommand sql_Create = new OleDbCommand($"INSERT INTO tbAluno(nome) VALUES('{nomeAluno}')", conexao);

            conexao.Open();

            int i = sql_Create.ExecuteNonQuery();

            if (i > 0)
            {
                Console.WriteLine("Inserção concluída com sucesso!");
            }

            conexao.Close();
        }
    }
}
