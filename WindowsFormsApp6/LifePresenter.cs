using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class LifePresenter
    {
        IView _IView;
        LifeSession Life;
        InnerColonies InnerColony;
        OuterColonies OuterColony;
        public LifePresenter(IView _IView) 
        {
            this._IView = _IView;
            _IView.CellClicked += _IVIew_CellClicked;
            _IView.CycleTick += _IVIew_CycleTick;
            _IView.ClearField += _IView_ClearField;
            _IView.SetChosenInnerColony += _IView_SetChosenInnerColony;
            _IView.SaveColony += _IView_SaveColony;
            _IView.LoadColony += _IView_LoadColony;
            Life = new LifeSession();
            InnerColony = new InnerColonies();
            OuterColony = new OuterColonies(new BinaryColony());
            Life.FieldChanged += Life_FieldChanged;
        }

        private void _IView_LoadColony(string fromPath)
        {
            ColonySnapshot snapshot = OuterColony.GetColony(fromPath);
            Life.PlaceColonyOnField(new ReadOnlyCollection<(int, int)>(snapshot.Colony), snapshot.GenerationCounter);
        }

        private void _IView_SaveColony(string toPath)
        {
            OuterColony.SaveColony(new ColonySnapshot(Life.GetActiveCells().ToList(), Life.GenerationCounter), toPath);
        }

        private void _IView_SetChosenInnerColony(string colonyName)
        {
            Life.PlaceColonyOnField(InnerColony.GetColony(colonyName));
        }

        private void _IView_ClearField()
        {
            Life.KillCells();
        }

        private void Life_FieldChanged(Cell[,] field)
        {
            _IView.RefreshField(field);
            _IView.ChangeGenerationCounter(Life.GenerationCounter);
        }

        private void _IVIew_CycleTick()
        {
            Life.MakeCycle();
        }

        private void _IVIew_CellClicked(int x, int y)
        {
            Life.ChangeCellState(x, y);
        }
    }
}
