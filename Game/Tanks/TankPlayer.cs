﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    /// <summary>
    /// Базовый танк Playera
    /// </summary>
    [Serializable]
    abstract class TankPlayer : AnimationTank, IAddTankToDictionary
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="rect">Прямоугольник описывающий позицию объекта на экране, ширину и высоту</param>
        /// <param name="velocity">Скорость</param>
        /// <param name="direction">Направление движения</param>
        public TankPlayer(Rectangle rect, int velocity, Direction direction, int velosityShel)
            : base(rect, velocity, direction, velosityShel)
        { }

        public void AddTankToDictionary()
        {
            Level.DictionaryObjGame[KeyObjGame.Player].Add(this);
        }
    }
}
