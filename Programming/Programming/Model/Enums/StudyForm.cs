using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Перечисление, представляющее формы обучения.
    /// </summary>
    internal enum StudyForm
    {
        /// <summary>
        /// Очная форма обучения.
        /// </summary>
        FullTime,

        /// <summary>
        /// Очно-заочная форма обучения.
        /// </summary>
        PartTime,

        /// <summary>
        /// Вечерняя форма обучения.
        /// </summary>
        Evening,

        /// <summary>
        /// Дистанционная форма обучения.
        /// </summary>
        Distance
    }
}