using System;
using System.Data.OleDb;

namespace CRUD_UPDATE
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection conexao = new OleDbConnection(@"Provider = SQLOLEDB;
                                                            Data Source = COMP20L2\SQLEXPRESS;
                                                            Initial Catalog = RestauranteUS;
                                                            User ID = sa; Password = sa;");

            Console.Write("Entre com o id do usuário que deseja alterar: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Entre com o novo nome de usuário: ");
            string newUsername = Console.ReadLine();

            Console.Write("Entre com a nova senha: ");
            string newPassword = Console.ReadLine();

            OleDbCommand sql_Update = new OleDbCommand($"UPDATE tbLogin SET username = '{newUsername}', password = '{newPassword}' WHERE Id = {id}", conexao);

            conexao.Open();

            int i = sql_Update.ExecuteNonQuery();

            if (i > 0)
            {
                Console.WriteLine("\nAtualização concluída com sucesso!");
            }

            conexao.Close();
        }
    }
}
