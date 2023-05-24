using Composicao.Entities;
using System;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Revistas rev = new Revistas();

            rev.codigo = 3;
            rev.titulo = "Forbes";
            rev.tipo = "Economia";

            rev.setEdicao(100, Convert.ToDateTime("28/04/2023"), 23);

            Console.WriteLine($"Código da revista: {rev.codigo}");
            Console.WriteLine($"Revista: {rev.titulo}");
            Console.WriteLine($"Tipo de publicação: {rev.tipo}");
            Console.WriteLine($"\nInformações de edição: ");

            rev.getEdicao();
        }
    }
}
