using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// Лед
    /// </summary>
    [Serializable]
    class Ice : ObjGame
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="position">Позиция на карте</param>
        public Ice(Point position)
            : base(new Rectangle(position.X, position.Y, SettingsGame.WidtchSmoll, SettingsGame.HeighSmoll))
        {
            // Установка картинки объекта
            spriteImage = Properties.Resources.Ice;
        }
    }
}
