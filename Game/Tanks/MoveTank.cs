﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// Движение танка
    /// </summary>
    [Serializable]
    abstract class MoveTank : CollisionsObjGame
    {
        // Состояния остановки
        protected bool isParking;
        // Cтарое направление движения
        protected Direction oldDirection;
        // Новое наравление движения
        protected Direction newDirection;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="rect">Прямоугольник описывающий позицию объекта на экране, ширину и высоту</param>
        /// <param name="velocity">Скорость</param>
        /// <param name="direction">Направление движения</param>
        public MoveTank(Rectangle rect, int velocity, Direction direction)
            : base(rect, velocity, direction)
        {
            isParking = true;
            newDirection = oldDirection = direction;
        }

        /// <summary>
        /// Движение танка
        /// </summary>
        protected override void Move()
        {
            // Если не стоит
            if (!isParking)
            {
                // Если старое напрвление не равно новому
                if (newDirection != oldDirection)
                {
                    // Смищение к границам тайла
                    if (offsetToBorderTile())
                        // Устанавливаем направление
                        direction = newDirection;
                }
                else
                    // Иначе базовое перемещение
                    base.Move();
            }
            else
                // Смещение к границам тайла
                offsetToBorderTile();
        }

        /// <summary>
        /// Смещение к границам тайла
        /// </summary>
        /// <returns>true если координаты танка кратны 20(танк на границе тайла)</returns>
        private bool offsetToBorderTile()
        {
            int tmp = (int)(oldDirection - newDirection);
            if (tmp == 2 || tmp == -2)
            {
                direction = newDirection;
                return false;
            }


            if (direction == Direction.Left)
            {
                int offset = spriteRectangle.X % SettingsGame.WidtchSmoll;
                if (offset == 0)
                    return true;

                if (offset >= velocity)
                    spriteRectangle.X -= velocity;
                else
                    spriteRectangle.X -= offset;
            }
            else if (direction == Direction.Up)
            {
                int offset = spriteRectangle.Y % SettingsGame.HeighSmoll;
                if (offset == 0)
                    return true;

                if (offset >= velocity)
                    spriteRectangle.Y -= velocity;
                else
                    spriteRectangle.Y -= offset;
            }
            else if (direction == Direction.Right)
            {
                int offset = SettingsGame.WidtchSmoll - spriteRectangle.X % SettingsGame.WidtchSmoll;
                if (offset == SettingsGame.WidtchSmoll)
                    return true;

                if (offset >= velocity)
                    spriteRectangle.X += velocity;
                else
                    spriteRectangle.X += offset;
            }
            else if (direction == Direction.Down)
            {
                int offset = SettingsGame.HeighSmoll - spriteRectangle.Y % SettingsGame.HeighSmoll;
                if (offset == SettingsGame.HeighSmoll)
                    return true;

                if (offset >= velocity)
                    spriteRectangle.Y += velocity;
                else
                    spriteRectangle.Y += offset;
            }

            return false;
        }
    }
}
