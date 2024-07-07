﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// Базовый класс для снаряда
    /// </summary>
    [Serializable]
    abstract class ShellObj : CollisionsObjGame
    {
        // true если сдетонировала
        protected bool detonation;
        public bool Detonation { get { return detonation; } set { detonation = value; } }
        // true если в полете
        protected bool isAlive;
        public bool IsAlive { get { return isAlive; } set { isAlive = value; } }

        public Direction Direction { get { return direction; } }

        // Имя танка, которому принадлежит снаряд
        protected KeyObjGame nameTank;
        public KeyObjGame NameTank
        {
            get { return nameTank; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="rect">Прямоугольник описывающий позицию объекта на экране, ширину и высоту</param>
        /// <param name="velocity">Скорость</param>
        /// <param name="direction">Направление движения</param>
        /// <param name="nameTank">Ссылка на танк которому пренадлежит снаряд</param>
        public ShellObj(Rectangle rect, int velocity, Direction direction, KeyObjGame nameTank)
            : base(rect, velocity, direction)
        {
            isAlive = true;
            this.nameTank = nameTank;
            this.velocity = velocity;
            this.direction = direction;

            // Загрузка картинок в зависимости от направления снаряда
            switch (direction)
            {
                case Direction.Up:
                    spriteImage = Properties.Resources.BulletUp;
                    break;
                case Direction.Right:
                    spriteImage = Properties.Resources.BulletRight;
                    break;
                case Direction.Down:
                    spriteImage = Properties.Resources.BulletDown;
                    break;
                case Direction.Left:
                    spriteImage = Properties.Resources.BulletLeft;
                    break;
            }
            // Добавление в список объектов игры
            Level.DictionaryObjGame[KeyObjGame.Shell].Add(this);
        }
    }
}
