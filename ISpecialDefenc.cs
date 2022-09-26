using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eliminating_Null_Reference_Exceptions
{
     public abstract class SpecialDefenc
    {
        public abstract int CalculateDamagReduction(int totalDamag);
         
        public static SpecialDefenc Null { get; }  = new NullDefence();

        private class NullDefence : SpecialDefenc
        {
            public override int CalculateDamagReduction(int totalDamag)
            {
                return 0;
            }
        }
    }
}
