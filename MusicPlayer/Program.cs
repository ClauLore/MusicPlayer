namespace MusicPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Song song1 =  new Song("Album","canción", "Es una canción para relajación","Pop");

            song1.Album="Nuevo Album";

            Console.WriteLine(song1.Album);

            song1.setAmount(100);


            Persona persona1 = new Persona("Fernanda", 25, 46589563);

            persona1.Age= 30;
            Console.WriteLine($"La edad es {persona1.Age}");



        }
    }
}
