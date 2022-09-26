using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eliminating_Null_Reference_Exceptions
{
    public class PlayerCharacter
    {
        private readonly ISpecialDefenc _specialDefenc;

        public PlayerCharacter(ISpecialDefenc specialDefenc)
        {
            _specialDefenc = specialDefenc;
        }

        public String Name {
            get; set; 
        }

        public int Health {
            get; set; 
        } = 100; 
        public void Hits(int damage)
        {
            int damageReduction = 0;
            if (_specialDefenc != null)
            {
                damageReduction = _specialDefenc.CalculateDamagReduction(damage);
            }
            int totalDamageTaken = damage - damageReduction;
            Health -= totalDamageTaken;
            Console.WriteLine($"{Name}'s reddekdfl from {totalDamageTaken} to {Health}");
        }
    }
}
