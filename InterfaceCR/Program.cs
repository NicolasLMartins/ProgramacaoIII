using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}