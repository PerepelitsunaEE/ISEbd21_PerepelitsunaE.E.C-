using System.Collections.Generic;

namespace WindowsFormsBoats
{
    class MultiLevelPort
    {
        /// <summary>
        /// Список с уровнями порта
        /// </summary>
        List<Port<IBoat>> parkingStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>
        private const int countPlaces = 20;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй порта</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelPort(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Port<IBoat>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Port<IBoat>(countPlaces, pictureWidth, pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Port<IBoat> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
    }
}
