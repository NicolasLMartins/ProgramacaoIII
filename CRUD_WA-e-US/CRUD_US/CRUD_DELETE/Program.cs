using System.Data.OleDb;
using System;

namespace CRUD_DELETE
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection conexao = new OleDbConnection(@"Provider = SQLOLEDB;
                                                            Data Source = COMP20L2\SQLEXPRESS;
                                                            Initial Catalog = RestauranteUS;
                                                            User ID = sa; Password = sa;");

            Console.Write("Entre com o id do usuário que deseja deletar: ");
            int id = int.Parse(Console.ReadLine());

            OleDbCommand sql_Delete = new OleDbCommand($"DELETE FROM tbLogin WHERE Id = {id}", conexao);

            conexao.Open();

            int i = sql_Delete.ExecuteNonQuery();

            if (i > 0)
            {
                Console.WriteLine("\nDeleção de registro realizada com sucesso!");
            }

            conexao.Close();
        }
    }
}
