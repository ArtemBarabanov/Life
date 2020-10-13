using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class OuterColonies
    {
        IRepository Repository;

        public OuterColonies(IRepository repository) 
        {
            Repository = repository;
        }

        public void SaveColony(ColonySnapshot snapshot, string toPath) 
        {
            Repository.SaveTo(snapshot, toPath);
        }

        public ColonySnapshot GetColony(string fromPath)
        {
            return Repository.LoadFrom(fromPath);
        }
    }
}
