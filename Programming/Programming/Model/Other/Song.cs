using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Other
{
    /// <summary>
    /// Представляет информацию о песне: название, автор, альбом и количество прослушиваний.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Поле для хранения названия песни.
        /// </summary>
        private string _songName;

        /// <summary>
        /// Поле для хранения количества прослушиваний.
        /// </summary>
        private int _listenings;

        /// <summary>
        /// Поле для хранения автора песни.
        /// </summary>
        private string _songAuthor;

        /// <summary>
        /// Поле для хранения названия альбома.
        /// </summary>
        private string _songAlbum;

        /// <summary>
        /// Возвращает и задаёт название песни. Длина строки должна быть положительной.
        /// </summary>
        public string SongName
        {
            get => _songName;
            set
            {
                Validator.AssertOnPositiveValue(value.Length, nameof(SongName));
            }
        }

        /// <summary>
        /// Возвращает и задаёт автора песни. Длина строки должна быть положительной.
        /// </summary>
        public string SongAuthor
        {
            get => _songAuthor;
            set
            {
                Validator.AssertOnPositiveValue(value.Length, nameof(SongAuthor));
            }
        }

        /// <summary>
        /// Возвращает и задаёт количество прослушиваний песни. Должно быть положительным числом.
        /// </summary>
        public int Listenings
        {
            get => _listenings;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Listenings));
            }
        }

        /// <summary>
        /// Возвращает и задаёт название альбома.
        /// </summary>
        public string SongAlbum { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/> со значениями по умолчанию.
        /// </summary>
        public Song() { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/> с указанными параметрами.
        /// </summary>
        /// <param name="songname">Название песни. Не должно быть пустым.</param>
        /// <param name="songauthor">Автор песни. Не должен быть пустым.</param>
        /// <param name="listenings">Количество прослушиваний. Должно быть положительным.</param>
        /// <param name="songalbum">Название альбома.</param>
        public Song(string songname, string songauthor, int listenings, string songalbum)
        {
            SongName = songname;
            SongAuthor = songauthor;
            Listenings = listenings;
            SongAlbum = songalbum;
        }
    }
}