﻿using System;
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

            Console.Write("Entre com o nome de usuário: ");
            string username = Console.ReadLine();

            Console.Write("Entre com a sua senha: ");
            string password = Console.ReadLine();

            OleDbCommand sql_Create = new OleDbCommand($"INSERT INTO tbLogin VALUES('{username}', '{password}')", conexao);

            conexao.Open();

            int i = sql_Create.ExecuteNonQuery();

            if (i > 0)
            {
                Console.WriteLine("\nInserção concluída com sucesso!");
            }

            conexao.Close();
        }
    }
}
