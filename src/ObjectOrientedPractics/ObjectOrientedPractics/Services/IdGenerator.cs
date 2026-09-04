using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    public static class IdGenerator
    {
        private static int _lastId = 0;

        public static int GetNextId()
        {
            _lastId++;
            return _lastId;
        }
    }
}
