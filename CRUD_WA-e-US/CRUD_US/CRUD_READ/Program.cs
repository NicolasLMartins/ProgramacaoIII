using System;
using System.Data.OleDb;

namespace CRUD_READ
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection conexao = new OleDbConnection(@"Provider = SQLOLEDB;
                                                            Data Source = COMP20L2\SQLEXPRESS;
                                                            Initial Catalog = RestauranteUS;
                                                            User ID = sa; Password = sa;");

            OleDbCommand sql_Read = new OleDbCommand("SELECT * FROM tbLogin", conexao);

            conexao.Open();

            OleDbDataReader lendo_dados = sql_Read.ExecuteReader();

            Console.WriteLine("LISTANDO OS DADOS DA TABELA\n");

            while (lendo_dados.Read())
            {
                Console.WriteLine($"{lendo_dados["username"]} - {lendo_dados["password"]}");
            }

            Console.WriteLine("\nFim da lista!");

            lendo_dados.Close();

            conexao.Close();
        }
    }
}
