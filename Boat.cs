﻿using System.Drawing;

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
    }
}
