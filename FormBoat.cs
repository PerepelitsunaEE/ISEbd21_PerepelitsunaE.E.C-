
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsBoats
{
    public partial class FormBoat : Form
    {
        private IBoat boat;
        /// <summary>
        /// Конструктор
        /// </summary>

        public FormBoat()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод отрисовки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBoats.Width, pictureBoxBoats.Height);
            Graphics gr = Graphics.FromImage(bmp);
            boat.DrawBoat(gr);
            pictureBoxBoats.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            boat = new Boat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.BurlyWood, Color.Turquoise, true, true);
            boat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBoats.Width, pictureBoxBoats.Height);
            Draw();
        }

        private void buttonCreateSail_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            boat = new Sail (rnd.Next(100, 300), rnd.Next(1000, 2000), Color.BurlyWood);
            boat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBoats.Width, pictureBoxBoats.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    boat.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    boat.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    boat.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    boat.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
