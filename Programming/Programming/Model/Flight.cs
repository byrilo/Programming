using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model
{
    public class Flight
    {
        private string _departurePoint;
        private string _destination;
        private int _minutesFlightTime;
        public int MinutesFlightTime
        {
            get
            {
                return _minutesFlightTime;
            }
            set
            {
                if (value < 1)
                {
                    MessageBox.Show("Ошибка. Неккоректное время полёта.");
                    _minutesFlightTime = value;
                }
            }

        }
        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public Flight() { }
        public Flight(string departurepoint, string destination, int minutesflighttime)
        {
            DeparturePoint = departurepoint;
            Destination = destination;
            MinutesFlightTime = minutesflighttime;
        }

    }
}
