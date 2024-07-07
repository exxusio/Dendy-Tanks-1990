using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// Отображение уровня игры
    /// </summary>
    [Serializable]
    class InformationAboutLevel : InformationGame
    {
        private Image spriteImage2;
        private bool twoDigits;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="rect">Прямоугольник описывающий позицию объекта на экране, ширину и высоту</param>
        public InformationAboutLevel(int carentLevel, Point position)
            : base(new Rectangle(position.X, position.Y, SettingsGame.WidtchSmoll, SettingsGame.HeighSmoll))
        {
            if (carentLevel / 10 > 0)
            {
                twoDigits = true;
                string path2 = SettingsGame.Content + @"Images\Other\" + (carentLevel / 10).ToString() + ".png";
                spriteImage2 = Image.FromFile(path2);
            }

            string path = SettingsGame.Content + @"Images\Other\" + (carentLevel % 10).ToString() + ".png";
            spriteImage = Image.FromFile(path);
        }

        public override void Draw(Graphics g, Point offset)
        {
            if (twoDigits)
            {
                g.TranslateTransform(spriteRectangle.X + offset.X - SettingsGame.WidtchSmoll, spriteRectangle.Y + offset.Y);
                g.DrawImage(spriteImage2, 0, 0, spriteRectangle.Width, spriteRectangle.Height);
                g.ResetTransform();
            }
            base.Draw(g, offset);
        }
    }
}
