using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class PhoneContact
    {
        private string _contactName;
        private string _contactSurname;
        private int _phoneNumber;
        private string _adress;

        public string ContactName // Свойcтво имени контакта
        {
            get
            {
                return _contactName;
            }
            set
            {
                if (value.Length < 0)
                {
                    MessageBox.Show("Ошибка. Введите имя.");
                    _contactName = value;
                }
            }
        }
        public int PhoneNumber // Свойcтво номера телефона
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value.ToString().Length != 11)
                {
                    MessageBox.Show("Ошибка. Введите верный номер.");
                    _phoneNumber = value;
                }
            }
        }
        public string Adress { get; set; } // Автосвойства
        public string ContactSurname { get; set; }

        public PhoneContact() { } // Конструкторы
        public PhoneContact(string contactname, int phonenumber, string adress, string contactsurname)
        {
            ContactName = contactname;
            PhoneNumber = phonenumber;
            Adress = adress;
            ContactSurname = contactname;
        }
    }
}
