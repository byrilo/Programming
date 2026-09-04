using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

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
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }
        public Item(string name, string info, double cost)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;            
        }

    }
}
