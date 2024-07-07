﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// Класс проверки на столкновения с границами карты
    /// </summary>
    [Serializable]
    abstract class CollisionsObjGame : MoweObjGame
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="rect">Прямоугольник описывающий позицию объекта на экране, ширину и высоту</param>
        /// <param name="velocity">Скорость</param>
        /// <param name="direction">Направление движения</param>
        protected CollisionsObjGame(Rectangle rect, int velocity, Direction direction)
            : base(rect, velocity, direction)
        { }

        /// <summary>
        /// Проверка на выход за границы карты
        /// </summary>
        /// <returns>Возвращает true если объект столкнулся с границами карты</returns>
        protected bool CollisionsBoundariesPlayingField()
        {
            switch (direction)
            {
                case Direction.Up:
                    if (spriteRectangle.Y <= 0)
                    {
                        spriteRectangle.Y = 0;
                        return true;
                    }
                    break;
                case Direction.Right:
                    if (spriteRectangle.X >= SettingsGame.WidtshPlayengFild - spriteRectangle.Width)
                    {
                        spriteRectangle.X = SettingsGame.WidtshPlayengFild - spriteRectangle.Width;
                        return true;
                    }
                    break;
                case Direction.Down:
                    if (spriteRectangle.Y >= SettingsGame.HeighPlayengFild - spriteRectangle.Height)
                    {
                        spriteRectangle.Y = SettingsGame.HeighPlayengFild - spriteRectangle.Height;
                        return true;
                    }
                    break;
                case Direction.Left:
                    if (spriteRectangle.X <= 0)
                    {
                        spriteRectangle.X = 0;
                        return true;
                    }
                    break;
            }

            return false;
        }
    }
}
