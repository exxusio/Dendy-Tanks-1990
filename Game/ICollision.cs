using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface ICollision
    {
        /// <summary>
        /// Позиции на карте, ширины и высоты объекта
        /// </summary>
        Rectangle Rect { get; }
    }
}
