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
    /// Экран игры
    /// </summary>
    class ScreenGame : Label
    {

        /// <summary>
        /// Конструктор экрана игры
        /// </summary>
        /// <param name="control">Принимает родительский Control</param>
        public ScreenGame(Control control)
        {
            Parent = control;
            Location = new Point();
            ClientSize = new Size(SettingsGame.WidtchWindowGame, SettingsGame.HeighWindowGame);
            BackColor = Color.Black;
            GraphicsOption();
        }

        private void GraphicsOption()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            // Смещение для объектов игры
            Point offset = new Point(SettingsGame.WidtchSmoll, SettingsGame.HeighSmoll);

            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Отрисовка фона
            BackgroundPpainting(g);


            // Прорисовка всех объектов игры
            foreach (var list in Level.DictionaryObjGame.Values)
            {
                foreach (var item in list)
                {
                    item.Draw(g, offset);
                }
            }

            foreach (var item in Level.ListInformation)
            {
                item.Draw(g, offset);
            }
        }

        // Отрисовка фона
        private static void BackgroundPpainting(Graphics g)
        {
            Image dashboard = Properties.Resources.Dashboard;
            g.TranslateTransform(SettingsGame.WidtshPlayengFild + SettingsGame.WidtchSmoll, 0);
            g.DrawImage(dashboard, 0, 0, SettingsGame.WidtchSmoll * 4, SettingsGame.HeighPlayengFild + SettingsGame.HeighSmoll * 2);
            g.ResetTransform();

            Image borderHorizontal = Properties.Resources.BorderHorizontal;
            g.TranslateTransform(0, 0);
            g.DrawImage(borderHorizontal, 0, 0, SettingsGame.WidtshPlayengFild + SettingsGame.HeighSmoll * 2, SettingsGame.HeighSmoll);
            g.ResetTransform();

            g.TranslateTransform(0, SettingsGame.HeighPlayengFild + SettingsGame.HeighSmoll);
            g.DrawImage(borderHorizontal, 0, 0, SettingsGame.WidtshPlayengFild + SettingsGame.HeighSmoll * 2, SettingsGame.HeighSmoll);
            g.ResetTransform();

            Image borderVertical = Properties.Resources.BorderVertical;
            g.TranslateTransform(0, 0);
            g.DrawImage(borderVertical, 0, 0, SettingsGame.WidtchSmoll, SettingsGame.HeighPlayengFild + SettingsGame.HeighSmoll * 2);
            g.ResetTransform();
        }
    }
}
