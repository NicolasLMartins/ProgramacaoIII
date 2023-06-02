namespace app.entities
{
    public interface IControlador
    {
        bool Ligar();
        bool Desligar();
        void AbrirMenu();
        void FecharMenu();
        void MaisVolume();
        void MenosVolume();
        void LigarMudo();
        void DesligarMudo();
        void Play();
        void Pause();
    }
}