using Items.Interfaces;

namespace Items
{
    public class Personaje : IPersonaje
    {
        int PuntosDeVidaMaxima; 
        public int PuntosDeVidaActual;
        public int PuntosDeAtaque;
        public int Armadura;
        public IEquipable armadura;
        public IEquipable Arma;

        public void Atacar(IPersonaje rival)
        {
            rival.RecibirAtaque(CalcularPuntosDeAtaque());
        }

        public void RecibirAtaque(int puntosDeAtaque)
        {
            PuntosDeVidaActual -= puntosDeAtaque;
        }

        public int CalcularPuntosDeAtaque()
        {
            return PuntosDeAtaque + Arma.PuntosDeAtaque();
        }
    }
}
