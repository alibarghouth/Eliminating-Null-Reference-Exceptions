using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eliminating_Null_Reference_Exceptions
{
    public class IronBonesDefence : SpecialDefenc
    {
        public override  int CalculateDamagReduction(int totalDamag)
        {
            return 5;
        }
    }
}
