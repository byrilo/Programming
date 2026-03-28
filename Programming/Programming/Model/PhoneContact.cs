using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms; // Для MessageBox

namespace Programming.Model
{
    public class PhoneContact
    {
        private string _contactName;
        private string _contactSurname;
        private int _phoneNumber;
        private string _adress;

        // Свойство имени контакта с валидацией
        public string ContactName
        {
            get => _contactName;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(ContactName));
                _contactName = value;
            }
        }

        // Свойство фамилии контакта с валидацией
        public string ContactSurname
        {
            get => _contactSurname;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(ContactSurname));
                _contactSurname = value;
            }
        }

        // Свойство номера телефона
        public int PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                // номер должен быть 11 цифр
                if (value.ToString().Length != 11)
                {
                    MessageBox.Show("Ошибка. Введите верный номер (11 цифр).");
                    // не присваиваем некорректное значение
                    return;
                }
                _phoneNumber = value;
            }
        }

        public string Adress { get; set; }

        /// <summary>
        /// Проверяет, что строка содержит только символы английского алфавита.
        /// </summary>
        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            // Проверка на пустоту
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"Значение не может быть пустым", propertyName);
            }

            // Проверка через регулярное выражение: только буквы A-Z и a-z
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                // Текст исключения свойство
                throw new ArgumentException($"Некорректное значение в свойстве {propertyName}", propertyName);
            }
        }

        // Конструкторы
        public PhoneContact() { }

        public PhoneContact(string contactname, int phonenumber, string adress, string contactsurname)
        {
            // Используем свойства, чтобы сработала валидация
            ContactName = contactname;
            PhoneNumber = phonenumber;
            Adress = adress;
            ContactSurname = contactsurname; // ✅ Исправлено: было contactname
        }
    }
}