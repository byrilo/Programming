using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Song
    {
        private string _songName;
        private int _listenings;
        private string _songAuthor;
        private string _songAlbum;

        public string SongName // Свойcтво названия песни
        {
            get
            {
                return _songName;
            }
            set
            {
                if (value.Length < 0)
                {
                    MessageBox.Show("Ошибка. Введите название песни.");
                    _songName = value;
                }
            }
        }
        public string SongAuthor // Свойcтво автора
        {
            get
            {
                return _songAuthor;
            }
            set
            {
                if (value.Length < 0)
                {
                    MessageBox.Show("Ошибка. Введите автора песни.");
                    _songAuthor = value;
                }
            }
        }
        public int Listenings // Свойcтво прослушиваний
        {
            get
            {
                return _listenings;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Ошибка. Прослушивания не могут быть отрицательными.");
                    _listenings = value;
                }
            }
        }
        public string SongAlbum { get; set; }
        public Song() { } // Конструкторы
        public Song(string songname, string songauthor, int listenings, string songalbum)
        {
            SongName = songname;
            SongAuthor = songauthor;
            Listenings = listenings;
            SongAlbum = songalbum;
        }
    }
}

