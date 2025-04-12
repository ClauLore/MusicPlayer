using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Persona
    {
        public string Name;
        public int Age;
        public int DNI;

        public Persona(string nombre, int edad, int dni) 
        {
            Name = nombre;
            Age = edad;
            DNI = dni;
        }
        
    }
}
