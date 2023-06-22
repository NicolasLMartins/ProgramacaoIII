using System;
using System.Data.OleDb;

namespace BD_DELETE
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection conexao = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0;
                                                            Data Source = C:\Users\Técnico\Desktop\Nicolas\DB_Escola.mdb");

            conexao.Open();

            Console.Write("Digite o código do aluno que deseja excluir: ");
            int codAluno = int.Parse(Console.ReadLine());

            OleDbCommand sql_Delete = new OleDbCommand($"DELETE FROM tbAluno WHERE idAluno = {codAluno}", conexao);

            sql_Delete.ExecuteNonQuery();

            Console.WriteLine("Exclusão concluída com sucesso!");

            conexao.Close();
        }
    }
}
