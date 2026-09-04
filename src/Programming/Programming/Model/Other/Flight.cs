using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Other
{
    /// <summary>
    /// Представляет информацию о рейсе: пункт вылета, пункт назначения и время в полёте.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Поле для хранения пункта вылета.
        /// </summary>
        private string _departurePoint;

        /// <summary>
        /// Поле для хранения пункта назначения.
        /// </summary>
        private string _destination;

        /// <summary>
        /// Поле для хранения времени полёта в минутах.
        /// </summary>
        private int _minutesFlightTime;

        /// <summary>
        /// Возвращает и задаёт время полёта в минутах. Должно быть положительным числом.
        /// </summary>
        public int MinutesFlightTime
        {
            get => _minutesFlightTime;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(MinutesFlightTime));
            }
        }

        /// <summary>
        /// Возвращает и задаёт пункт вылета.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задаёт пункт назначения.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/> со значениями по умолчанию.
        /// </summary>
        public Flight() { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/> с указанными параметрами.
        /// </summary>
        /// <param name="departurepoint">Пункт вылета.</param>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="minutesflighttime">Время полёта в минутах. Должно быть положительным.</param>
        public Flight(string departurepoint, string destination, int minutesflighttime)
        {
            DeparturePoint = departurepoint;
            Destination = destination;
            MinutesFlightTime = minutesflighttime;
        }
    }
}