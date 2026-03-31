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
            get => _songName;
            set
            {
                Validator.AssertOnPositiveValue(value.Length, nameof(SongName));
            }
        }
        public string SongAuthor // Свойcтво автора
        {
            get => _songAuthor;            
            set
            {
                Validator.AssertOnPositiveValue(value.Length, nameof(SongAuthor));
            }
        }
        public int Listenings // Свойcтво прослушиваний
        {
            get => _listenings;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Listenings));
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

