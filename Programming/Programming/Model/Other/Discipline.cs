using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Other
{
    /// <summary>
    /// Представляет информацию об учебной дисциплине: название, оценку, преподавателя и количество часов.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Поле для хранения названия дисциплины.
        /// </summary>
        private string _disciplineName;

        /// <summary>
        /// Поле для хранения оценки по дисциплине.
        /// </summary>
        private int _grade;

        /// <summary>
        /// Поле для хранения имени преподавателя.
        /// </summary>
        private string _teacher;

        /// <summary>
        /// Поле для хранения количества часов по дисциплине.
        /// </summary>
        private int _disciplineHours;

        /// <summary>
        /// Возвращает и задаёт название дисциплины. Длина строки должна быть положительной.
        /// </summary>
        public string DisciplineName
        {
            get => _disciplineName;
            set
            {
                Validator.AssertOnPositiveValue(value.Length, nameof(DisciplineName));
            }
        }

        /// <summary>
        /// Возвращает и задаёт оценку по дисциплине. Должна находиться в диапазоне от 0 до 5.
        /// </summary>
        public int Grade
        {
            get => _grade;
            set
            {
                Validator.AssertValueInRange(value, 0, 5, nameof(Grade));
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя преподавателя. Длина строки должна быть положительной.
        /// </summary>
        public string Teacher
        {
            get => _teacher;
            set
            {
                Validator.AssertOnPositiveValue(value.Length, nameof(Teacher));
            }
        }

        /// <summary>
        /// Возвращает и задаёт количество часов по дисциплине. Должно быть положительным числом.
        /// </summary>
        public int DisciplineHours
        {
            get => _disciplineHours;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DisciplineHours));
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Discipline"/> со значениями по умолчанию.
        /// </summary>
        public Discipline() { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Discipline"/> с указанными параметрами.
        /// </summary>
        /// <param name="disciplinename">Название дисциплины. Не должно быть пустым.</param>
        /// <param name="grade">Оценка по дисциплине. Должна находиться в диапазоне от 0 до 5.</param>
        /// <param name="teacher">Имя преподавателя. Не должно быть пустым.</param>
        /// <param name="disciplinehours">Количество часов по дисциплине. Должно быть положительным.</param>
        public Discipline(string disciplinename, int grade, string teacher, int disciplinehours)
        {
            DisciplineName = disciplinename;
            Grade = grade;
            Teacher = teacher;
            DisciplineHours = disciplinehours;
        }
    }
}