using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Song
    {
        private string _album;
        public string Album
        {
            get { return _album; }
            set {  _album = value; }
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _description { get; set; }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private String _genre { get; set; }
        public String Genre
        {
            get => _genre;
            set => _genre = value; 
        }

        private double Amount;

        public Song(string album, string title, string descripcion, string genero)
        {
            Album = album;
            Title = title;
            Description = descripcion;
            Genre = genero;

        }

        public double setAmount(double amount)
        {
            if (amount < 0)
            {
                throw new Exception("Error");
            }
            Amount = amount;
            return Amount;
        }
        //Encapsulación
        //public string getAlbum()
        //{
        //    return Album;
        //}

        //public void setAlbum(string album)
        //{
        //    Album = album;
        //}

        //public string getTitle()
        //{
        //    return Title;
        //}

        //public void setTitle(string title)
        //{
        //    Title = title;
        //}

        //public string getDescription()
        //{
        //    return Description;
        //}

        //public void setGenre(string genre)
        //{
        //    this.Genre=genre;
        //}

        //public string getGenre () 
        //{
        //    return this.Genre;
        //}

       


    }
}

