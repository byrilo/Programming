using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Other
{
    public class Flight
    {
        private string _departurePoint;
        private string _destination;
        private int _minutesFlightTime;
        public int MinutesFlightTime // Свойство минут в полёте
        {
            get => _minutesFlightTime;        
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(MinutesFlightTime));
            }

        }
        public string DeparturePoint { get; set; } // Автосвойства
        public string Destination { get; set; }
        public Flight() { } // Конструкторы
        public Flight(string departurepoint, string destination, int minutesflighttime)
        {
            DeparturePoint = departurepoint;
            Destination = destination;
            MinutesFlightTime = minutesflighttime;
        }

    }
}
