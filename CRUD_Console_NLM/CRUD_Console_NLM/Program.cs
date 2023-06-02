using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Console_NLM
{
    class Program
    {
        static void Main(string[] args)
        {

            //1º Criar uma conexão com o DB
            OleDbConnection conexao = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0;
                                                            Data Source = C:\Users\Técnico\Desktop\Nicolas\DB_Escola.mdb");

            //2º Criar um objeto de instrução SQL
            OleDbCommand sqlRead = new OleDbCommand("SELECT * FROM tbAluno", conexao);

            //3º Abrir a conexão
            conexao.Open();
            
            //PARA LEITURA DE DADOS
            
            //4º Criar uma variável de referência a uma classe
            //que lerá os dados na tabela
            //5º Listar os dados na tela
            //6º Fechar o DataReader e a conexão
            
        }
    }
}
