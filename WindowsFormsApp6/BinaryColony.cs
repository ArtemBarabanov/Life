using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    //Колония в бинарном формате
    class BinaryColony : IRepository
    {
        public ColonySnapshot LoadFrom(string destinationName)
        {
            ColonySnapshot Snapshot;
            BinaryFormatter Formatter = new BinaryFormatter();
            using (FileStream stream = File.Open(destinationName, FileMode.Open))
            {
                Snapshot = (ColonySnapshot)Formatter.Deserialize(stream);
            }
            return Snapshot;
        }

        public void SaveTo(ColonySnapshot snapshot, string destinationName)
        {
            BinaryFormatter Formatter = new BinaryFormatter();
            using (FileStream stream = File.Open(destinationName, FileMode.OpenOrCreate)) 
            {
                Formatter.Serialize(stream, snapshot);
            }
        }
    }
}
