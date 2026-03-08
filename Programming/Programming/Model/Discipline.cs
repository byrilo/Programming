using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Discipline
    {
        private string _disciplineName;
        private int _grade;
        private string _teacher;
        private int _disciplineHours;

        public string DisciplineName // Свойcтво названия дисциплины
        {
            get
            {
                return _disciplineName;
            }
            set
            {
                if (value.Length < 0)
                {
                    MessageBox.Show("Ошибка. Введите название дисциплины.");
                    _disciplineName = value;
                }
            }
        }
        public int Grade // Свойcтво оценки
        {
            get
            {
                return _grade;
            }
            set
            {
                if (value < 0 && value > 5)
                {
                    MessageBox.Show("Ошибка. Введите корректное значение оценки.");
                    _grade = value;
                }
            }
        }
        public string Teacher // Свойcтво имени преподавателя
        {
            get
            {
                return _teacher;
            }
            set
            {
                if (value.Length < 0)
                {
                    MessageBox.Show("Ошибка. Введите имя преподавателя.");
                    _teacher = value;
                }
            }
        }
        public int DisciplineHours // Свойcтво оценки
        {
            get
            {
                return _disciplineHours;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Ошибка. Введите корректное значение часов дисциплины.");
                    _disciplineHours = value;
                }
            }
        }
        public Discipline() { } // Конструкторы
        public Discipline(string disciplinename, int grade, string teacher, int disciplinehours)
        {
            DisciplineName = disciplinename;
            Grade = grade;
            Teacher = teacher;
            DisciplineHours = disciplinehours;
        }
    }
}
