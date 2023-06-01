using app.entities;

namespace POO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleRemoto CR = new ControleRemoto();

            CR.Ligar();
            CR.MaisVolume();
            // CR.LigarMudo();
            CR.Play();
            CR.AbrirMenu();
            System.Console.ReadKey();
        }
    }
}