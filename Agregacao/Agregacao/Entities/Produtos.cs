using System;

namespace Agregacao.Entities
{
    class Produtos
    {
        public int codigo;
        public string descProduto;
        public float preco;
        public int quantidade;

        public void ListaDados()
        {
            Console.WriteLine($"\nCódigo.......: {this.codigo}");
            Console.WriteLine($"Descrição....: {this.descProduto}");
            Console.WriteLine($"Preço R$.....: {this.preco.ToString("0.00")}");
            Console.WriteLine($"Quantidade...: {this.quantidade}");
        }
    }
}
