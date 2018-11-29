using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsBoats
{
    public partial class FormSailConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная лодка
        /// </summary>
        IBoat sail = null;

        /// <summary>
        /// Событие
        /// </summary>
        private event sailDelegate eventAddSail;

        public FormSailConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отрисовать лодку
        /// </summary>
        private void DrawSail()
        {
            if (sail != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxConfig.Width, pictureBoxConfig.Height);
                Graphics gr = Graphics.FromImage(bmp);
                sail.SetPosition(5, 5, pictureBoxConfig.Width, pictureBoxConfig.Height);
                sail.DrawBoat(gr);
                pictureBoxConfig.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(sailDelegate ev)
        {
            if (eventAddSail == null)
            {
                eventAddSail = new sailDelegate(ev);
            }
            else
            {
                eventAddSail += ev;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelSail_MouseDown(object sender, MouseEventArgs e)
        {
            labelSail.DoDragDrop(labelSail.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBoat_MouseDown(object sender, MouseEventArgs e)
        {
            labelBoat.DoDragDrop(labelBoat.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelConfig_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelConfig_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычная лодка":
                    sail = new Sail(100, 500, Color.White);
                    break;
                case "Парусник":
                    sail = new Boat(100, 500, Color.White, Color.Black, true, true);
                    break;
            }
            DrawSail();
        }

        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (sail != null)
            {
                sail.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawSail();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (sail != null)
            {
                if (sail is Boat)
                {
                    (sail as Boat).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawSail();
                }
            }
        }
        /// <summary>
        /// Добавление лодки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddSail?.Invoke(sail);
            Close();
        }


        private void FormSailConfig_Load(object sender, EventArgs e)
        {

        }

    }
}
