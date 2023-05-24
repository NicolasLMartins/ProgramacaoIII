using System;

namespace Composicao.Entities
{
    class Revistas
    {
        public int codigo;
        public string titulo;
        public string tipo;
        public Edicoes edicao;

        public Revistas()
        {
            this.edicao = new Edicoes();
        }

        public void setEdicao(int numEdicao, DateTime dataEdicao, int numArtigos)
        {
            this.edicao.setEdicao(numEdicao, dataEdicao, numArtigos);
        }

        public void getEdicao()
        {
            this.edicao.getEdicao();
        }
    }
}
