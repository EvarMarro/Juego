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

        public Personaje(int puntosDeVida, int armadura)
        {
            PuntosDeVidaActual = puntosDeVida;
            PuntosDeAtaque = puntosDeVida;
            Armadura = armadura;
            equipamiento = new List<IEquipable>();
        }
        public override string ToString()
        {
            return string.Format("Se crea un personaje con {0} puntos de vida y {1} de armadura", PuntosDeVidaActual, Armadura );
        }
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
            int puntosAdquiridos = equipamiento
                                    .Select(x => x.PuntosDeAtaque())
                                    .Sum();
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
