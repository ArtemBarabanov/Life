using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    interface IRepository
    {
        void SaveTo(ColonySnapshot snapshot, string destinationName);
        ColonySnapshot LoadFrom(string source);
    }
}
