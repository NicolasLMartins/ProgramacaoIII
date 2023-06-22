using System;
using System.Data.OleDb;

namespace CRUD_CREATE
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection conexao = new OleDbConnection(@"Provider = SQLOLEDB;
                                                            Data Source = COMP20L2\SQLEXPRESS;
                                                            Initial Catalog = RestauranteUS;
                                                            User ID = sa; Password = sa;");

            Console.WriteLine("Entre com o nome de usuário: ");
            string username = Console.ReadLine();

            Console.WriteLine("Entre com a sua senha: ");
            string password = Console.ReadLine();

            OleDbCommand sql_Create = new OleDbCommand($"INSERT INTO tbAluno VALUES('{username}', '{password}')", conexao);

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
