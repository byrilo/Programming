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
            get => _disciplineName;
            set
            {                               
                Validator.AssertOnPositiveValue(value.Length, nameof(DisciplineName));               
            }
        }
        public int Grade // Свойcтво оценки
        {
            get => _grade;            
            set
            {
                    Validator.AssertValueInRange(value, 0, 5, nameof(Grade));
            }
        }
        public string Teacher // Свойcтво имени преподавателя
        {
            get => _teacher;
            set
            {
                Validator.AssertOnPositiveValue(value.Length, nameof(Teacher));
            }
        }
        public int DisciplineHours // Свойcтво оценки
        {
            get => _disciplineHours;           
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DisciplineHours));
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
