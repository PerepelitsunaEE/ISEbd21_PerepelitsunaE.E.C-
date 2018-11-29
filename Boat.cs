using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsBoats
{
    public class Boat : Sail
    {        
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия правого паруса
        /// </summary>
        public bool RightSail { private set; get; }
        /// <summary>
        /// Признак наличия левого паруса
        /// </summary>
        public bool LeftSail { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес </param>
        /// <param name="mainColor">Основной цвет лодки</param>
        /// <param name="dopColor">Дополнительный цвет (парус)</param>
        /// <param name="RightSail">Признак наличия правого паруса</param>
        /// <param name="LeftSail">Признак наличия левого паруса</param>
        /// 

        public Boat (int maxSpeed, float weight, Color mainColor, Color dopColor, bool rightSail, bool leftSail) :
                    base (maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            RightSail = rightSail;
            LeftSail = leftSail;
        }

        public Boat(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                RightSail = Convert.ToBoolean(strs[4]);
                LeftSail = Convert.ToBoolean(strs[5]);
            }
        }

        public override void DrawBoat(Graphics g)
        {
            Pen pen = new Pen(MainColor, 3);
            Pen pen1 = new Pen(DopColor, 2);
            
            if (RightSail)
            {
                g.DrawLine(pen1, _startPosX + 45, _startPosY + 40, _startPosX + 45, _startPosY);
                g.DrawLine(pen1, _startPosX + 45, _startPosY, _startPosX + 70, _startPosY + 40);
            }
            if (LeftSail)
            {
                g.DrawLine(pen1, _startPosX + 45, _startPosY + 40, _startPosX + 45, _startPosY);
                g.DrawLine(pen1, _startPosX + 45, _startPosY, _startPosX + 20, _startPosY + 40);
            }
            base.DrawBoat(g);
        }
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + RightSail + ";" + LeftSail;
        }
    }
}
