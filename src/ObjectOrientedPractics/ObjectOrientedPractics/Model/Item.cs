using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        public int Id
        {
            get { return _id; }
        }
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Стоимость должна быть от 0 до 100000.");
                }
                _cost = value;
            }
        }

    }
}
