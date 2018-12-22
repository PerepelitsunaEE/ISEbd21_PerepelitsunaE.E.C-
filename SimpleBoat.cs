using System.Drawing;

namespace WindowsFormsBoats
{
    public abstract class SimpleBoat : IBoat
    {
        /// <summary>
        /// Левая координата отрисовки парусника
        /// </summary>
        protected float _startPosX;

        /// <summary>
        /// Правая кооридната отрисовки парусника
        /// </summary>
        protected float _startPosY;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;

        //Высота окна отрисовки
        protected int _pictureHeight;

        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { protected set; get; }

        /// <summary>
        /// Вес парусника
        /// </summary>
        public float Weight { protected set; get; }

        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void SetMainColor(Color color)
        {
            MainColor = color;
        }

        public abstract void DrawBoat(Graphics g);

        public abstract void MoveTransport(Direction direction);
    }
}
