using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class LifeSession
    {
        Cell[,] OriginalField;
        Cell[,] NewField;
        public int GenerationCounter { get; private set; }

        public event Action<Cell[,]> FieldChanged;

        public LifeSession() 
        {
            OriginalField = new Cell[40, 40];
            NewField = new Cell[40, 40];
            CreateField();
        }

        /// <summary>
        /// Создание полей
        /// </summary>
        private void CreateField() 
        {
            for (int i = 0; i < OriginalField.GetLength(0); i++)
            {
                for (int j = 0; j < OriginalField.GetLength(1); j++)
                {
                    OriginalField[i, j] = new Cell(i, j);
                    NewField[i, j] = new Cell(i, j);
                }
            }
        }

        /// <summary>
        /// Изменение состояния клетки
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void ChangeCellState(int x, int y) 
        {
            if (OriginalField[x, y].IsAlive)
            {
                OriginalField[x, y].IsAlive = false;
            }
            else 
            {
                OriginalField[x, y].IsAlive = true;
            }

            FieldChanged(OriginalField);
        }

        /// <summary>
        /// Сброс колонии и параметров
        /// </summary>
        public void KillCells() 
        {
            for (int i = 0; i < NewField.GetLength(0); i++)
            {
                for (int j = 0; j < NewField.GetLength(1); j++)
                {
                    NewField[i, j].IsAlive = false;
                    OriginalField[i, j].IsAlive = false;
                }
            }
            GenerationCounter = 0;
            FieldChanged(OriginalField);
        }

        /// <summary>
        /// Один полный цикл жизни колонии
        /// </summary>
        public void MakeCycle() 
        {
            int count = 0;

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    if (j + 1 < 40)
                    {
                        if (OriginalField[i, j + 1].IsAlive == true)
                        {
                            count += 1;
                        }
                    }
                    if (j - 1 > -1)
                    {
                        if (OriginalField[i, j - 1].IsAlive == true)
                        {
                            count += 1;
                        }
                    }
                    if (i + 1 < 40)
                    {
                        if (OriginalField[i + 1, j].IsAlive == true)
                        {
                            count += 1;
                        }
                    }
                    if (i - 1 > -1)
                    {
                        if (OriginalField[i - 1, j].IsAlive == true)
                        {
                            count += 1;
                        }
                    }
                    if (j + 1 < 40 & i + 1 < 40)
                    {
                        if (OriginalField[i + 1, j + 1].IsAlive == true)
                        {
                            count += 1;
                        }
                    }
                    if (j - 1 > -1 & i - 1 > -1)
                    {
                        if (OriginalField[i - 1, j - 1].IsAlive == true)
                        {
                            count += 1;
                        }
                    }
                    if (i - 1 > -1 & j + 1 < 40)
                    {
                        if (OriginalField[i - 1, j + 1].IsAlive == true)
                        {
                            count += 1;
                        }
                    }
                    if (i + 1 < 40 & j - 1 > -1)
                    {
                        if (OriginalField[i + 1, j - 1].IsAlive == true)
                        {
                            count += 1;
                        }
                    }

                    if (!OriginalField[i, j].IsAlive) 
                    { 

                        if (count == 3)
                        {
                            NewField[i, j].IsAlive = true;
                        }
                    }
                    if (OriginalField[i, j].IsAlive) 
                    {
                        if (count < 2 | count > 3)
                        {
                            NewField[i, j].IsAlive = false;
                        }
                        else 
                        {
                            NewField[i, j].IsAlive = true;
                        }
                    }
                    count = 0;
                }
            }

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    OriginalField[i, j].IsAlive = NewField[i, j].IsAlive;
                }
            }

            GenerationCounter++;
            FieldChanged(NewField);
        }

        #region Использование готовых колоний из внешних источников или определенных в проекте
        public void PlaceColonyOnField(ReadOnlyCollection<(int, int)> coordinates) 
        {
            foreach (var(x, y) in coordinates) 
            {
                OriginalField[x, y].IsAlive = true;
                NewField[x, y].IsAlive = true;
            }
            FieldChanged(NewField);
        }

        public void PlaceColonyOnField(ReadOnlyCollection<(int, int)> coordinates, int generationCounter)
        {
            GenerationCounter = generationCounter;
            foreach (var (x, y) in coordinates)
            {
                OriginalField[x, y].IsAlive = true;
                NewField[x, y].IsAlive = true;
            }
            FieldChanged(NewField);
        }

        public List<(int, int)> GetActiveCells() 
        {
            var Answer = new List<(int, int)>();
            foreach (Cell cell in OriginalField)
            {
                if (cell.IsAlive) 
                {
                    Answer.Add((cell.X, cell.Y));
                }
            }
            return Answer;
        }
        #endregion
    }
}
