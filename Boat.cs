using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsBoats
{
    public class Boat
    {

        /// <summary>
        /// Левая координата отрисовки парусника
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки парусника 
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        //Высота окна отрисовки
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки парусника
        /// </summary>
        private const int boatWidth = 100;
        /// <summary>
        /// Ширина отрисовки парусника
        /// </summary>
        private const int boatHeight = 60;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес парусника
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
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
        public Boat (int maxSpeed, float weight, Color mainColor, Color dopColor, bool rightSail, bool leftSail)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            RightSail = rightSail;
            LeftSail = leftSail;
        }
        /// <summary>
        /// Установка позиции парусника
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
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
        /// <summary>
        /// Отрисовка парусника
        /// </summary>
        /// <param name="g"></param>
        public void DrawBoat(Graphics g)
        {
            Pen pen = new Pen(MainColor, 3);
            Pen pen1 = new Pen(DopColor, 2);
            g.DrawLine(pen, _startPosX + 20, _startPosY + 60, _startPosX + 70, _startPosY + 60);
            g.DrawLine(pen, _startPosX, _startPosY +  40, _startPosX + 90, _startPosY + 40);
            g.DrawLine(pen, _startPosX + 20, _startPosY + 60, _startPosX, _startPosY + 40);
            g.DrawLine(pen, _startPosX + 70, _startPosY + 60, _startPosX + 90, _startPosY + 40);
            
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
        }
    }
}
