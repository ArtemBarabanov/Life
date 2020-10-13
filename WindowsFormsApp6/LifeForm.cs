using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class LifeForm : Form, IView
    {
        public LifeForm()
        {
            InitializeComponent();
            saveFileDialog.Filter = "Файлы колоний(*.sns)|*.sns";
            openFileDialog.Filter = "Файлы колоний(*.sns)|*.sns";
            openFileDialog.DefaultExt = ".sns";
        }

        CellVisual[,] Field = new CellVisual[40, 40]; 

        public event Action<int, int> CellClicked;
        public event Action CycleTick;
        public event Action ClearField;
        public event Action<string> SetChosenInnerColony;
        public event Action<string> SaveColony;
        public event Action<string> LoadColony;

        private void Form1_Load(object sender, EventArgs e)
        {
            Cycle_Timer.Stop();
            CreateField();
        }

        private void CreateField() 
        {
            int X, Y = 0;
            for (int i = 0; i < 40; i++)
            {
                X = 0;
                for (int j = 0; j < 40; j++)
                {
                    Field[i, j] = new CellVisual(i, j);
                    Field[i, j].Location = new Point(X, Y);
                    Field[i, j].Size = new Size(20, 20);
                    Field[i, j].BackColor = Color.White;
                    Field[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Controls.Add(Field[i, j]);
                    Field[i, j].Click += Cell_Click;
                    X = X + 20;
                }
                Y = Y + 20;
            }
            Y = 0;
        }

        /// <summary>
        /// Обработчик нажатия на клетку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cell_Click(object sender, EventArgs e)
        {
            CellVisual Cell = sender as CellVisual;
            CellClicked(Cell.PositionX, Cell.PositionY);
        }

        /// <summary>
        /// Обработчик выбора колонии через ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RewindHelper();
            SetChosenInnerColony(SetsComboBox.SelectedItem.ToString());
        }

        private void RewindHelper() 
        {
            ClearField();
            ClickCount = 0;
            GenerationBox.Text = "0";
            Pause();
        }

        /// <summary>
        /// Нажатие на кнопку Сброс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rewind_Click(object sender, EventArgs e)
        {
            RewindHelper();
        }

        /// <summary>
        /// Обработка изменение положения указателя трекбара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpeedBar_Scroll(object sender, EventArgs e)
        {
            if (SpeedBar.Value == 0)
            {
                Cycle_Timer.Interval = 1000;
            }
            else if (SpeedBar.Value == 1) 
            {
                Cycle_Timer.Interval = 500;
            }
            else if (SpeedBar.Value == 2)
            {
                Cycle_Timer.Interval = 250;
            }
            else if (SpeedBar.Value == 3)
            {
                Cycle_Timer.Interval = 119;
            }
            else if (SpeedBar.Value == 3)
            {
                Cycle_Timer.Interval = 12;
            }
        }

        /// <summary>
        /// Тик счетчика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cycle_Timer_Tick(object sender, EventArgs e)
        {
            CycleTick();
        }

        public void RefreshField(Cell[,] FieldData)
        {
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    if (FieldData[i, j].IsAlive)
                    {
                        Field[i, j].BackColor = Color.Green;
                    }
                    else
                    {
                        Field[i, j].BackColor = Color.White;
                    }
                }
            }
        }

        public void ChangeGenerationCounter(int count) 
        {
            GenerationBox.Text = count.ToString();
        }

        /// <summary>
        /// Обработка нажатия на кнопку Старт/Стоп
        /// </summary>
        int ClickCount;
        private void Start_Stop_Click(object sender, EventArgs e)
        {
            if (ClickCount % 2 == 0)
            {
                Continue();
            }
            else if (ClickCount % 2 != 0)
            {
                Pause();
            }
            ClickCount++;
        }

        private void Pause() 
        {
            Start_Stop.Text = "Старт";
            Cycle_Timer.Stop();
        }

        private void Continue() 
        {
            Start_Stop.Text = "Пауза";
            Cycle_Timer.Interval = 200;
            Cycle_Timer.Start();
        }

        /// <summary>
        /// Обработка нажатия на кнопку Загрузить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_Button_Click(object sender, EventArgs e)
        {
            RewindHelper();
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                LoadColony(openFileDialog.FileName);
            }
        }

        /// <summary>
        /// Обработка нажатия на кнопку Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Button_Click(object sender, EventArgs e)
        {
            Pause();
            ClickCount = 0;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveColony(saveFileDialog.FileName);
            }
        }

        /// <summary>
        /// Обработка нажатия на кнопку Что это такое?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WhatButton_Click(object sender, EventArgs e)
        {
            string Text = "Игра «Жизнь» (англ. Conway's Game of Life) - клеточный автомат, придуманный английским математиком Джоном Конвеем в 1970 году. \nМесто действия этой игры - размеченная на клетки поверхность или плоскость - безграничная, ограниченная, или замкнутая(в пределе -бесконечная плоскость). \nКаждая клетка на этой поверхности может находиться в двух состояниях: быть «живой» (заполненной)или быть «мёртвой» (пустой).Клетка имеет восемь соседей, окружающих её. \nРаспределение живых клеток в начале игры называется первым поколением.Каждое следующее поколение рассчитывается на основе предыдущего по таким правилам: \nв пустой(мёртвой) клетке, рядом с которой ровно три живые клетки, зарождается жизнь; \nЕсли у живой клетки есть две или три живые соседки, то эта клетка продолжает жить; в противном случае, если соседей меньше двух или больше трёх, клетка умирает («от одиночества» или «от перенаселённости». Чтобы задать первое поколение, необходимо или кликать по клеткам на поле, или выбрать один из вариантов размещения живых клеток с помощью пункта Выбрать колонию)";
            MessageBox.Show(Text);
        }
    }
}
