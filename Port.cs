using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;

namespace WindowsFormsBoats
{
    /// <summary>
    /// Параметризованны класс для хранения набора объектов от интерфейса IBoat
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Port <T> : IEnumerator<T>, IEnumerable<T>, IComparable<Port<T>>
        where T : class, IBoat
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private Dictionary<int, T> _places;
        /// <summary>
        /// Максимальное количество мест 
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
        /// Текущий элемент для вывода через IEnumerator (будет обращаться по своему индексу к ключу словаря, по которму будет возвращаться запись)
        /// </summary>
        private int _currentIndex;
        /// <summary>
        /// Получить порядковое место на парковке
        /// </summary>
        public int GetKey
        {
            get
            {
                return _places.Keys.ToList()[_currentIndex];
            }
        }
        /// Конструктор
        /// </summary>
        /// <param name="sizes">Количество мест в гавани</param>
        /// <param name="pictureWidth">Рамзер гавани - ширина</param>
        /// <param name="pictureHeight">Рамзер гавани - высота</param>
        public Port(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            _currentIndex = -1;
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
                throw new PortOverflowException();
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
                else if (sail.GetType() == p._places[i].GetType())
                {
                    if (sail is Boat)
                    {
                        if ((sail as Boat).Equals(p._places[i]))
                        {
                            throw new PortAlreadyHaveException();
                        }
                    }
                    else if ((sail as Sail).Equals(p._places[i]))
                    {
                        throw new PortAlreadyHaveException();
                    }
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
            throw new PortNotFoundException(index);
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
            foreach (var sail in _places)
            {
                sail.Value.DrawBoat(g);
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

        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                throw new PortNotFoundException(ind);
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5 * _placeSizeHeight + 15, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new PortOccupiedPlaceException(ind);
                }
            }
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для получения текущего элемента
        /// </summary>
        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для получения текущего элемента
        /// </summary>
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        /// <summary>
        /// Метод интерфейса IEnumerator, вызываемый при удалении объекта
        /// </summary>
        public void Dispose()
        {
            _places.Clear();
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        /// </summary>
        public void Reset()
        {
            _currentIndex = -1;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        /// <summary>
        /// Метод интерфейса IComparable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Port<T> other)
        {
            if (_places.Count > other._places.Count)
            {
                return -1;
            }
            else if (_places.Count < other._places.Count)
            {
                return 1;
            }
            else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; ++i)
                {
                    if (_places[thisKeys[i]] is Sail && other._places[thisKeys[i]] is Boat)
                    {
                        return 1;
                    }
                    if (_places[thisKeys[i]] is Boat && other._places[thisKeys[i]] is Sail)
                    {
                        return -1;
                    }
                    if (_places[thisKeys[i]] is Sail && other._places[thisKeys[i]] is Sail)
                    {
                        return (_places[thisKeys[i]] is Sail).CompareTo(other._places[thisKeys[i]] is Sail);
                    }
                    if (_places[thisKeys[i]] is Boat && other._places[thisKeys[i]] is Boat)
                    {
                        return (_places[thisKeys[i]] is Boat).CompareTo(other._places[thisKeys[i]] is Boat);
                    }
                }
            }
            return 0;
        }

    }
}
