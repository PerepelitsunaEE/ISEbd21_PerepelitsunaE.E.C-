using System;
using System.Drawing;

namespace WindowsFormsBoats
{
    public class Sail : SimpleBoat
    {
        protected const int boatWidth = 100;
        /// <summary>
        /// Ширина отрисовки парусника
        /// </summary>
        protected const int boatHeight = 60;
        
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес </param>
        /// <param name="mainColor">Основной цвет лодки</param>
        public Sail (int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Sail(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - boatWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - boatHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawBoat(Graphics g)
        {
            Pen pen = new Pen(MainColor, 3);
            g.DrawLine(pen, _startPosX + 20, _startPosY + 60, _startPosX + 70, _startPosY + 60);
            g.DrawLine(pen, _startPosX, _startPosY + 40, _startPosX + 90, _startPosY + 40);
            g.DrawLine(pen, _startPosX + 20, _startPosY + 60, _startPosX, _startPosY + 40);
            g.DrawLine(pen, _startPosX + 70, _startPosY + 60, _startPosX + 90, _startPosY + 40);

        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

    }
}
