using System;

namespace Composicao.Entities
{
    class Edicoes
    {
        int numEdicao;
        DateTime dataEdicao;
        int numArtigos;

        public void setEdicao(int numEdicao, DateTime dataEdicao, int numArtigos)
        {
            this.numEdicao = numEdicao;
            this.dataEdicao = dataEdicao;
            this.numArtigos = numArtigos;
        }

        public void getEdicao()
        {
            Console.WriteLine($"Número da edição: {this.numEdicao}");
            Console.WriteLine($"Edição: {this.dataEdicao.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Quantidade de artigos: {this.numArtigos}");
        }
    }
}
