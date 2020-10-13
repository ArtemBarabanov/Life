using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    //Захардкоженные колонии
    class InnerColonies
    {
        List<(int, int)> Crux;
        List<(int, int)> Pentadecatlon;
        List<(int, int)> Blink;
        List<(int, int)> Galaxy;
        List<(int, int)> SpaceShip;
        List<(int, int)> Glider;
        List<(int, int)> Clocks;
        List<(int, int)> Spinner;
        List<(int, int)> Shotgun;

        public InnerColonies() 
        {
            Crux = CreateCrux();
            Pentadecatlon = CreatePentadecatlon();
            Blink = CreateBlink();
            Galaxy = CreateGalaxy();
            SpaceShip = CreateSpaceship();
            Glider = CreateGlider();
            Clocks = CreateClocks();
            Spinner = CreateSpinner();
            Shotgun = CreateShotgun();
        }

        public ReadOnlyCollection<(int, int)> GetColony(string colonyName) 
        {
            switch (colonyName) 
            {
                case "Крест": return new ReadOnlyCollection<(int, int)>(Crux);
                case "Пентадекатлон": return new ReadOnlyCollection<(int, int)>(Pentadecatlon);
                case "Мигалка": return new ReadOnlyCollection<(int, int)>(Blink);
                case "Галактика": return new ReadOnlyCollection<(int, int)>(Galaxy);
                case "Космический корабль": return new ReadOnlyCollection<(int, int)>(SpaceShip);
                case "Планер": return new ReadOnlyCollection<(int, int)>(Glider);
                case "Часы": return new ReadOnlyCollection<(int, int)>(Clocks);
                case "Вертушка": return new ReadOnlyCollection<(int, int)>(Spinner);
                case "Ружье": return new ReadOnlyCollection<(int, int)>(Shotgun);
                default: return new ReadOnlyCollection<(int, int)>(new List<(int, int)>());
            }
        }

        //Крест
        private List<(int, int)> CreateCrux()
        {
            return new List<(int, int)> { (15, 17), (15, 18), (15, 19), (15, 20), (22, 17), (22, 18), (22, 19), (22, 20), (17, 15), (17, 16), (17, 17), (17, 20), (17, 21), (17, 22), (20, 15), (20, 16), (20, 17), (20, 20), (20, 21), (20, 22),
            (16, 17), (21, 17), (16, 20), (21, 20), (18, 15), (19, 15), (18, 22), (19, 22)
            };
        }

        ////Пентадекатлон
        private List<(int, int)> CreatePentadecatlon()
        {
            return new List<(int, int)> {
                (18, 17), (18, 18), (18, 19), (18, 20), (18, 21), (18, 22), (22, 17), (22, 18), (22, 19), (22, 20), (22, 21), (22, 22),
                (19, 16), (19, 23), (20, 15), (20, 24), (21, 16), (21, 23) 
            };
        }

        ////Мигалка
        private List<(int, int)> CreateBlink()
        {
            return new List<(int, int)> {
                (20, 20), (20, 21), (20, 22) 
            };
        }

        ////Галактика Кока
        private List<(int, int)> CreateGalaxy()
        {
            return new List<(int, int)>{
                 (15, 15), (16, 15), (17, 15), (18, 15), (19, 15), (20, 15),
                 (15, 16), (16, 16), (17, 16), (18, 16), (19, 16), (20, 16),
                 (15, 18), (15, 19), (15, 20), (15, 21), (15, 22), (15, 23),
                 (16, 18), (16, 19), (16, 20), (16, 21), (16, 22), (16, 23),
                 (22, 15), (22, 16), (22, 17), (22, 18), (22, 19), (22, 20),
                 (23, 15), (23, 16), (23, 17), (23, 18), (23, 19), (23, 20),
                 (18, 22), (19, 22), (20, 22), (21, 22), (22, 22), (23, 22),
                 (18, 23), (19, 23), (20, 23), (21, 23), (22, 23), (23, 23),
            };
        }

        ////Космический корабль
        private List<(int, int)> CreateSpaceship()
        {
            return new List<(int, int)> {
                 (18, 3), (18, 4), (19, 1), (19, 6), (20, 7), (21, 1), (21, 7), (22, 2), (22, 3), (22, 4), (22, 5), (22, 6), (22, 7)
            };
        }

        ////Планер
        private List<(int, int)> CreateGlider()
        {
            return new List<(int, int)> {
                (1, 2), (2, 3), (3, 1), (3, 2), (3, 3) 
            };
        }

        ////Часы
        private List<(int, int)> CreateClocks()
        {
            return new List<(int, int)> { 
                (18, 14), (18, 15), (19, 14), (19, 15),
                (14, 20), (14, 21), (15, 20), (15, 21),
                (20, 24), (20, 25), (21, 24), (21, 25),
                (24, 18), (24, 19), (25, 18), (25, 19),
                (17, 18), (17, 19), (17, 20), (17, 21), (22, 18), (22, 19), (22, 20), (22, 21),
                (18, 17), (19, 17), (20, 17), (21, 17), (18, 22), (19, 22), (20, 22), (21, 22),
                (18, 20), (19, 19), (20, 19),
            };
        }

        ////Вертушка
        private List<(int, int)> CreateSpinner()
        {
            return new List<(int, int)> { 
                (18, 14), (18, 15), (19, 14), (19, 15),
                (14, 20), (14, 21), (15, 20), (15, 21),
                (20, 24), (20, 25), (21, 24), (21, 25),
                (24, 18), (24, 19), (25, 18), (25, 19),
                (17, 18), (17, 19), (17, 20), (17, 21), (22, 18), (22, 19), (22, 20), (22, 21),
                (18, 17), (19, 17), (20, 17), (21, 17), (18, 22), (19, 22), (20, 22), (21, 22),
                (18, 20), (19, 19), (20, 21)
            };
        }

        ////Ружье
        private List<(int, int)> CreateShotgun()
        {
            return new List<(int, int)>{ 
                (5, 1), (5, 2), (6, 1), (6, 2),
                (3, 35), (3, 36), (4, 35), (4, 36),
                (3, 13), (3, 14), (4, 12), (4, 16), (5, 11), (5, 17), (6, 11), (6, 15), (6, 17), (6, 18), (7, 11), (7, 17), (8, 12), (8, 16), (9, 13), (9, 14),
                (1, 25), (2, 23), (2, 25), (3, 21), (3, 22), (4, 21), (4, 22), (5, 21), (5, 22), (6, 23),  (6, 25), (7, 25) };
        }
    }
}
