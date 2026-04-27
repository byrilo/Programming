using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Model.Other
{
    /// <summary>
    /// Представляет контактную информацию человека: имя, фамилию, номер телефона и адрес.
    /// </summary>
    public class PhoneContact
    {
        /// <summary>
        /// Поле для хранения имени контакта.
        /// </summary>
        private string _contactName;

        /// <summary>
        /// Поле для хранения фамилии контакта.
        /// </summary>
        private string _contactSurname;

        /// <summary>
        /// Поле для хранения номера телефона.
        /// </summary>
        private int _phoneNumber;

        /// <summary>
        /// Поле для хранения адреса контакта.
        /// </summary>
        private string _adress;

        /// <summary>
        /// Возвращает и задаёт имя контакта. Должно содержать только буквы английского алфавита.
        /// </summary>
        public string ContactName
        {
            get => _contactName;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(ContactName));
                _contactName = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию контакта. Должна содержать только буквы английского алфавита.
        /// </summary>
        public string ContactSurname
        {
            get => _contactSurname;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(ContactSurname));
                _contactSurname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона. Должен содержать ровно 11 цифр.
        /// </summary>
        public int PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value.ToString().Length != 11)
                {
                    MessageBox.Show("Ошибка. Введите верный номер.");
                    return;
                }
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес контакта.
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// Проверяет, что строка содержит только символы английского алфавита.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства для сообщения об ошибке.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если строка пустая или содержит недопустимые символы.</exception>
        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"Значение не может быть пустым", propertyName);
            }

            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException($"Некорректное значение в свойстве {propertyName}", propertyName);
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PhoneContact"/> со значениями по умолчанию.
        /// </summary>
        public PhoneContact() { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PhoneContact"/> с указанными параметрами.
        /// </summary>
        /// <param name="contactname">Имя контакта. Должно содержать только буквы.</param>
        /// <param name="phonenumber">Номер телефона. Должен содержать 11 цифр.</param>
        /// <param name="adress">Адрес контакта.</param>
        /// <param name="contactsurname">Фамилия контакта. Должна содержать только буквы.</param>
        public PhoneContact(string contactname, int phonenumber, string adress, string contactsurname)
        {
            ContactName = contactname;
            PhoneNumber = phonenumber;
            Adress = adress;
            ContactSurname = contactsurname;
        }
    }
}