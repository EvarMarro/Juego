namespace Items.Interfaces
{
    public interface IEquipable
    {
        void Equipar(IPersonaje personaje);
        int PuntosDeAtaque();
        int PuntosDeArmadura();
    }
}
