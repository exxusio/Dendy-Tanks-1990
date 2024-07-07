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
    /// Отображение в завершения игры Level
    /// </summary>
    [Serializable]
    class ImgGameOver : InformationGame
    {
        private bool isShow;
        private int intervalGameOver;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public ImgGameOver()
            : base(new Rectangle(SettingsGame.WidtchSmoll * 11, SettingsGame.HeighWindowGame, SettingsGame.WidtchSmoll * 4, SettingsGame.WidtchSmoll * 2))
        {
            isShow = true;
            intervalGameOver = 60;
            spriteImage = Properties.Resources.GameOver;
        }

        public void Update()
        {
            if (spriteRectangle.Y > SettingsGame.HeighWindowGame / 2 - spriteImage.Height / 2)
                spriteRectangle.Y -= 10;

            intervalGameOver--;

            if (intervalGameOver == 40)
                SoundGame.GameOver();

            if (intervalGameOver == 0)
            {
                isShow = false;
                DandyTanks.StateOfGame = StateOfGame.GameOver;
            }
        }

        public bool IsShow()
        {
            return isShow;
        }
    }
}
