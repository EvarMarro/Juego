using Items.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Items
{
    public class Personaje : IPersonaje
    {
        int PuntosDeVidaMaxima;
        public int PuntosDeVidaActual;
        public int PuntosDeAtaque;
        public int Armadura;
        public List<IEquipable> equipamiento;

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
            int puntosAdquiridos = 0;
            foreach(var x in equipamiento)
            {
                puntosAdquiridos += x.PuntosDeAtaque();
            }
            return PuntosDeAtaque + puntosAdquiridos;
        }

        public void Equipar(IEquipable equipo)
        {
            QuitarPiezaSiExiste(equipo);
            equipamiento.Add(equipo);
        }

        public void QuitarPiezaSiExiste(IEquipable equipo)
        {
            var piezaDeEquipo = equipamiento.Find(x => x.Tipo() == equipo.Tipo());
            if (piezaDeEquipo != null)
            {
                equipamiento.Remove(piezaDeEquipo);
            }
        }
    }
}
