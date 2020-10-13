using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    [Serializable]
    class ColonySnapshot
    {
        public int GenerationCounter { get; }
        public List<(int, int)> Colony { get; }

        public ColonySnapshot(List<(int, int)> colony, int generationCounter) 
        {
            GenerationCounter = generationCounter;
            Colony = colony;
        }
    }
}
