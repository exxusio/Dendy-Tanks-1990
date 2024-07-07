using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// Настройки игры
    /// </summary>
    struct SettingsGame
    {
        static SettingsGame()
        {
            heighSmoll = 20;
            widtchSmoll = 20;

            heighBig = HeighSmoll * 2;
            widtchBig = WidtchSmoll * 2;

            heighPlayengFild = 26 * HeighSmoll;
            widtshPlayengFild = 26 * WidtchSmoll;

            widtchWindowGame = 31 * WidtchSmoll;
            heighWindowGame = 28 * HeighSmoll;

            heighShell = 7;
            widtchShell = 5;
        }

        /// <summary>
        /// Высота больших объектов
        /// </summary>
        public static int HeighBig { get { return heighBig; } }
        private static int heighBig;
        /// <summary>
        /// Ширина больших объектов
        /// </summary>
        public static int WidtchBig { get { return widtchBig; } }
        private static int widtchBig;

        /// <summary>
        /// Высота маленьких объектов
        /// </summary>
        public static int HeighSmoll { get { return heighSmoll; } }
        private static int heighSmoll;

        /// <summary>
        /// Ширина маленьких объектов
        /// </summary>
        public static int WidtchSmoll { get { return widtchSmoll; } }
        private static int widtchSmoll;

        /// <summary>
        /// Высота снаряда
        /// </summary>
        public static int HeighShell { get { return heighShell; } }
        private static int heighShell;

        /// <summary>
        /// Ширина снаряда
        /// </summary>
        public static int WidtchShell { get { return widtchShell; } }
        private static int widtchShell;

        /// <summary>
        /// Ширина игрового поля
        /// </summary>
        public static int HeighPlayengFild { get { return heighPlayengFild; } }
        private static int heighPlayengFild;

        /// <summary>
        /// Высота игрового поля
        /// </summary>
        public static int WidtshPlayengFild { get { return widtshPlayengFild; } }
        private static int widtshPlayengFild;

        /// <summary>
        /// Ширина клиенской части окна игры
        /// </summary>
        public static int WidtchWindowGame { get { return widtchWindowGame; } }
        private static int widtchWindowGame;

        /// <summary>
        /// Высота клиенской части окна игры
        /// </summary>
        public static int HeighWindowGame { get { return heighWindowGame; } }
        private static int heighWindowGame;

        /// <summary>
        /// Количество уровней
        /// </summary>
        public static int CountLevel { get { return countLevel; } }
        private static int countLevel;

        public static string Content { get { return @"..\..\Resources\Content\"; } }
    }
}
