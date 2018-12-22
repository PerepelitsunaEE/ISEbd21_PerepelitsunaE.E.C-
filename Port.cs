using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace WindowsFormsBoats
{
    /// <summary>
    /// Параметризованны класс для хранения набора объектов от интерфейса IBoat
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Port <T> where T : class, IBoat
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private Dictionary<int, T> _places;
        /// <summary>
        /// Максимальное количество мест на парковке
        /// </summary>
        private int _maxCount;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int PictureWidth { get; set; }
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int PictureHeight { get; set; }
        /// <summary>
        /// Размер гавани (ширина)
        /// </summary>
        private int _placeSizeWidth = 210;
        /// <summary>
        /// Размер гавани (высота)
        /// </summary>
        private int _placeSizeHeight = 80;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sizes">Количество мест в гавани</param>
        /// <param name="pictureWidth">Рамзер гавани - ширина</param>
        /// <param name="pictureHeight">Рамзер гавани - высота</param>
        public Port(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на гавань добавляется лодка
        /// </summary>
        /// <param name="p">Гавань</param>
        /// <param name="sail">Добавляемая лодка</param>
        /// <returns></returns>
        public static int operator +(Port<T> p, T sail)
        {
            if (p._places.Count == p._maxCount)
            {
                return -1;
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, sail);
                    p._places[i].SetPosition(5 + i / 5 * p._placeSizeWidth + 5,
                    i % 5 * p._placeSizeHeight + 15, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с гавани забираем лодку
        /// </summary>
        /// <param name="p">Гавань</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        /// <returns></returns>
        public static T operator -(Port<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T sail = p._places[index];
                p._places.Remove(index);
                return sail;
            }
            return null;
        }
        /// <summary>
        /// Метод проверки заполнености гавани (ячейки массива)
        /// </summary>
        /// <param name="index">Номер парковочного места (порядковый номер в массиве)</param>
        /// <returns></returns>
        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }
        /// <summary>
        /// Метод отрисовки гавани
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].DrawBoat(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы праковки
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 5; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
    }
}