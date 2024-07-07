using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// Танк для боковой панели
    /// </summary>
    [Serializable]
    class InformationTank : InformationGame
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="position">Позиция на экране</param>
        public InformationTank(Point position)
            : base(new Rectangle(position, Properties.Resources.InformationTank.Size))
        {
            // Установка картинки объекта
            spriteImage = Properties.Resources.InformationTank;
        }
    }
}
