using Associacao.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Editoras edit = new Editoras();

            edit.codEditora = 5;
            edit.razaoSocial = "Finnis Editora";
            edit.contato = "Pity Xixito";
            edit.telefone = "(51) 99999-6565";

            Livros liv = new Livros();

            liv.codigo = 542;
            liv.descLivro = "C# OPP";
            liv.ISBN = "123.456.789.10";
            liv.editora = edit;

            Console.WriteLine("Implementando os dados: ");
            Console.WriteLine($"Código do livro: {liv.codigo}");
            Console.WriteLine($"Título do livro: {liv.descLivro}");
            Console.WriteLine($"ISBN do livro: {liv.ISBN}");
            Console.WriteLine($"Codigo da editora: {liv.editora.codEditora}");
            Console.WriteLine($"Nome da editora: {liv.editora.razaoSocial}");
            Console.WriteLine($"Contato: {liv.editora.contato}");
            Console.WriteLine($"Telefone: {liv.editora.telefone}");
        }
    }
}
