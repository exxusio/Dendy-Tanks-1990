using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface IDraw
    {
        /// <summary>
        /// Рисует объект игры
        /// </summary>
        /// <param name="g">Graphics экрана игры</param>
        /// <param name="offset">Смещение на экране</param>
        void Draw(Graphics g, Point offset);
    }
}
