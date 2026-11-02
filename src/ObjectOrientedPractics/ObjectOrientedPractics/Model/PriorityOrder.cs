using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Приоритетный заказ: обычный заказ, для которого покупатель выбирает дату и время доставки.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Допустимые диапазоны времени доставки.
        /// </summary>
        public static readonly string[] AvailableDeliveryTimes =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        private DateTime _desiredDate;

        /// <summary>
        /// Желаемое время доставки (один из диапазонов <see cref="AvailableDeliveryTimes"/>).
        /// </summary>
        private string _desiredTime = AvailableDeliveryTimes[0];

        /// <summary>
        /// Возвращает и задаёт желаемую дату доставки.
        /// </summary>
        public DateTime DesiredDate
        {
            get { return _desiredDate; }
            set { _desiredDate = value; }
        }

        /// <summary>
        /// Возвращает и задаёт желаемое время доставки.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Значение не входит в список <see cref="AvailableDeliveryTimes"/>.
        /// </exception>
        public string DesiredTime
        {
            get { return _desiredTime; }
            set
            {
                if (Array.IndexOf(AvailableDeliveryTimes, value) < 0)
                {
                    throw new ArgumentException("Недопустимое время доставки.");
                }

                _desiredTime = value;
            }
        }

        /// <summary>
        /// Создаёт приоритетный заказ со статусом <see cref="OrderStatus.New"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Товары заказа.</param>
        /// <param name="desiredDate">Желаемая дата доставки.</param>
        /// <param name="desiredTime">Желаемое время доставки.</param>
        public PriorityOrder(Address address, List<Item> items, DateTime desiredDate, string desiredTime)
            : base(address, items)
        {
            DesiredDate = desiredDate;
            DesiredTime = desiredTime;
        }
    }
}