﻿
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// Лес
    /// </summary>
    [Serializable]
    class Forest : ObjGame
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="position">Позиция на карте</param>
        public Forest(Point position)
            : base(new Rectangle(position.X, position.Y, SettingsGame.WidtchSmoll, SettingsGame.HeighSmoll))
        {
            // Установка картинки объекта
            spriteImage = Properties.Resources.Forest;
        }
    }
}
