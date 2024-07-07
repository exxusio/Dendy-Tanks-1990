using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// Вода
    /// </summary>
    [Serializable]
    class Water : ObjGame
    {
        private int delay;
        private int carentFrame;
        private Image[] images;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="position">Позиция на карте</param>
        public Water(Point position)
            : base(new Rectangle(position.X, position.Y, SettingsGame.WidtchSmoll, SettingsGame.HeighSmoll))
        {
            // Установка картинки объекта
            images = new Image[] {
                                    Properties.Resources.Water_1,
                                    Properties.Resources.Water_2,
                                    Properties.Resources.Water_3 };

            delay = 0;
            carentFrame = 0;
            spriteImage = images[0];
        }

        /// <summary>
        /// Обновление состояния объекта
        /// </summary>
        public override void Update()
        {
            if (delay == 0)
            {
                delay = 30;
                spriteImage = images[carentFrame];
                carentFrame = carentFrame == 0 ? 1 : 0;
            }
            else if (delay == 20)
            {
                spriteImage = images[carentFrame];
                carentFrame = carentFrame == 1 ? 2 : 1;
                delay--;
            }
            else if (delay == 10)
            {
                spriteImage = images[carentFrame];
                carentFrame = 0;
                delay--;
            }
            else
                delay--;
        }
    }
}
