namespace Agregacao.Entities
{
    class Carrinho
    {
        Produtos[] itens = new Produtos[3];

        float total = 0F;

        public void IncluirItem(Produtos item1, Produtos item2, Produtos item3)
        {
            this.itens[0] = item1;
            this.itens[1] = item2;
            this.itens[2] = item3;
        }

        public void ExibeCarrinho()
        {
            foreach (var item in itens)
            {
                item.ListaDados();
            }
        }

        public float FecharCarrinho()
        {
            foreach (var item in itens)
            {
                total += item.preco * item.quantidade;
            }

            return total;
        }
    }
}
