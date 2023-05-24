using Agregacao.Entities;
using System;

namespace Agregacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos prod1 = new Produtos();
            Produtos prod2 = new Produtos();
            Produtos prod3 = new Produtos();

            prod1.codigo = 5;
            prod1.descProduto = "Suco de laranja";
            prod1.preco = 4F;
            prod1.quantidade = 2;

            prod2.codigo = 6;
            prod2.descProduto = "Suco de uva";
            prod2.preco = 3F;
            prod2.quantidade = 2;

            prod3.codigo = 7;
            prod3.descProduto = "Suco de mamão";
            prod3.preco = 5F;
            prod3.quantidade = 3;

            Carrinho carr = new Carrinho();

            carr.IncluirItem(prod1, prod2, prod3);

            Console.WriteLine($"Total da compra: {carr.FecharCarrinho().ToString("R$ " + "#,##" + "0.00")}");
            
            carr.ExibeCarrinho();
        }
    }
}
