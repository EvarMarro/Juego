namespace Items.Interfaces
{
    public interface IPersonaje
    {
        void Atacar(IPersonaje rival);
        void RecibirAtaque(int puntosDeAtaque);
        int CalcularPuntosDeAtaque();
    }
}
