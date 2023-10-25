using System;

namespace Tymakov_8
{
    internal class Song
    {
        string name; // название песни
        string author; // автор песни
        Song prev; // связь с предыдущей песней в списке

        // Метод для заполнения поля name
        public void SetName(string name)
        {
            this.name = name;
        }

        // Метод для заполнения поля author
        public void SetAuthor(string author)
        {
            this.author = author;
        }

        // Метод для заполнения поля prev
        public void SetPrev(Song prev)
        {
            this.prev = prev;
        }

        // Метод для печати названия песни и ее исполнителя
        public string Title()
        {
            return $"{name} - {author}";
        }

        // Метод, который сравнивает между собой два объекта-песни
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Song otherSong = (Song)obj;
            return name == otherSong.name && author == otherSong.author;
        }
    }
}
