using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для генерации уникальных идентификаторов.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Значение последнего сгенерированного идентификатора.
        /// </summary>
        private static int _lastId = 0;

        /// <summary>
        /// Возвращает следующий уникальный идентификатор.
        /// </summary>
        /// <returns> Следующий уникальный идентификатор </returns>
        public static int GetNextId()
        {
            _lastId++;
            return _lastId;
        }
    }
}
