using System;
using System.Data.OleDb;

namespace BD_UPDATE
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection conexao = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0;
                                                            Data Source = C:\Users\Técnico\Desktop\Nicolas\DB_Escola.mdb");

            conexao.Open();

            Console.Write("Digite o código do aluno para editar seu registro: ");
            int codAluno = int.Parse(Console.ReadLine());

            Console.Write("Digite o novo nome ou o nome corrigido: ");
            string nomeAluno = Console.ReadLine();

            OleDbCommand sql_Update = new OleDbCommand($"UPDATE tbAluno SET nome = '{nomeAluno}' WHERE idAluno = {codAluno}", conexao);

            sql_Update.ExecuteNonQuery();

            Console.WriteLine("\nAtualização concluida com sucesso!");

            conexao.Close();
        }
    }
}
