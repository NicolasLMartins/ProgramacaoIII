namespace app.entities
{
    public class ControleRemoto : IControlador
    {
        //Atributos
        private int volume;
        private bool ligado;
        private bool tocando;
        //Métodos especiais: CONSTRUTOR
        public ControleRemoto()
        {
            volume = 50;
            ligado = false;
            tocando = false;
        }
        //Métodos Especiais: Getters e Setters
        private int GetVolume()
        {
            return volume;
        }
        private bool GetLigado()
        {
            return ligado;
        }
        private bool GetTocando()
        {
            return tocando;
        }
        private void SetVolume(int vol)
        {
            volume = vol;
        }
        private void SetLigado(bool lig)
        {
            ligado = lig;
        }
        private void SetTocando(bool toc)
        {
            tocando = toc;
        }
        //MÉTODOS DA INTERFACE
        public bool Ligar()
        {
            ligado = true;
            return ligado;
        }
        public bool Desligar()
        {
            ligado = false;
            return ligado;
        }
        public void AbrirMenu()
        {
            Console.WriteLine("----- MENU -----");
            Console.WriteLine("Está ligado? " + GetLigado());
            Console.WriteLine("Está tocando? " + GetTocando());
            Console.Write("Volume: " + GetVolume() + ": ");
            for (int i = 0; i < GetVolume(); i++)
            {
                Console.Write("|");
            }
        }
        public void FecharMenu()
        {
            Console.WriteLine("Fechando o menu!");
        }
        public void MaisVolume()
        {
            if (GetLigado())
            {
                SetVolume(GetVolume() + 1);
            }
            else
            {
                Console.WriteLine("Impossível aumentar volume");
            }
        }
        public void MenosVolume()
        {
            if (GetLigado())
            {
                SetVolume(GetVolume() - 1);
            }
            else
            {
                Console.WriteLine("Impossível diminuir volume");
            }
        }
        public void LigarMudo()
        {
            if (GetLigado() && GetVolume() > 0)
            {
                SetVolume(0);
            }
        }
        public void DesligarMudo()
        {
            if (GetLigado() && GetVolume() == 0)
            {
                SetVolume(50);
            }
        }
        public void Play()
        {
            if (GetLigado() && !GetTocando())
            {
                SetTocando(true);
            }
            else
            {
                Console.WriteLine("Não consegui reproduzir!");
            }
        }
        public void Pause()
        {
            if (GetLigado() && GetTocando())
            {
                SetTocando(false);
            }
            else
            {
                Console.WriteLine("Não consegui pausar!");
            }
        }
    }
}