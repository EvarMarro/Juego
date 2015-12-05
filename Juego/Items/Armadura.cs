using Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Armadura : IArmadura
    {
        int puntosDeArmadura;

        public Armadura()
        {
            puntosDeArmadura = 100;
        }
        public void Encantamiento()
        {
            throw new NotImplementedException();
        }     

        public int PuntosDeAtaque()
        {
            return 0;
        }       

        public int Tipo()
        {
            return (int)EnumEquipables.Arma;
        }

        int IEquipable.PuntosDeArmadura()
        {
            return puntosDeArmadura;
        }      
    }
}
