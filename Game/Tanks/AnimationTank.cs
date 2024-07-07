using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    /// <summary>
    /// Анимация танка
    /// </summary>
    [Serializable]
    abstract class AnimationTank : FireTank
    {
        // Масив картинок для движения влево
        protected Image[] moweLeft;
        // Масив картинок для движения вправо
        protected Image[] moweRight;
        // Масив картинок для движения ввверх
        protected Image[] moweUp;
        // Масив картинок для движения ввниз
        protected Image[] moweDown;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="rect">Прямоугольник описывающий позицию объекта на экране, ширину и высоту</param>
        /// <param name="velocity">Скорость</param>
        /// <param name="direction">Направление движения</param>
        protected AnimationTank(Rectangle rect, int velocity, Direction direction, int velosityShel)
            : base(rect, velocity, direction, velosityShel)
        { }

        // Текущий кадр (индекс в масиве картинок)
        private int carrentFrame = 0;

        /// <summary>
        /// Анимация танка
        /// </summary>
        protected void Animation()
        {
            carrentFrame = carrentFrame == 1 ? 0 : 1;

            switch (direction)
            {
                case Direction.Up:
                    spriteImage = moweUp[carrentFrame];
                    break;
                case Direction.Right:
                    spriteImage = moweRight[carrentFrame];
                    break;
                case Direction.Down:
                    spriteImage = moweDown[carrentFrame];
                    break;
                case Direction.Left:
                    spriteImage = moweLeft[carrentFrame];
                    break;
            }
        }
    }
}
