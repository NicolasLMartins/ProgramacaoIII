using System;
using System.Data.OleDb;

namespace BD_READ
{
    class Program
    {
        static void Main(string[] args)
        {
            //1º Criar uma conexão com o BD
            OleDbConnection conexao = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0;
                                                            Data Source = C:\Users\Técnico\Desktop\Nicolas\DB_Escola.mdb");

            //2º Criar um objeto de instrução SQL
            OleDbCommand sql_Read = new OleDbCommand("SELECT * FROM tbAluno", conexao);

            //3º Abrir a conexão
            conexao.Open();

            //PARA A LEITURA DE DADOS
            //4º Criar uma variável de referência a uma classe que lerá os dados na tabela
            OleDbDataReader lendo_dados = sql_Read.ExecuteReader();

            //5º Listar os dados na tela
            Console.WriteLine("LISTANDO OS DADOS DA TABELA\n");

            while (lendo_dados.Read())
            {
                //Mostra as colunas pelo GET
                //Console.WriteLine($"Pelo GET: {lendo_dados["idAluno"]} - {lendo_dados.GetString(1)}");

                //Mostra as colunas pelo nome da coluna
                Console.WriteLine($"Pela coluna: {lendo_dados["idAluno"]} - {lendo_dados["nome"]}");
            }

            Console.WriteLine("\nFim da lista!");

            //6º Fechar o DataReader e a conexão
            lendo_dados.Close();
            conexao.Close();

            Console.ReadKey();
        }
    }
}
