using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    interface IView
    {
        event Action<int, int> CellClicked;
        event Action CycleTick;
        event Action ClearField;
        event Action<string> SetChosenInnerColony;
        event Action<string> SaveColony;
        event Action<string> LoadColony;
        void RefreshField(Cell[,] FieldData);
        void ChangeGenerationCounter(int count);
    }
}
