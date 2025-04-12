using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Persona
    {
        private string _name;
        private int _age;
        private int _dni;

        public Persona(string nombre, int edad, int dni) 
        {
            this._name = nombre;
            this._age = edad;
            this._dni = dni;
        }

        public string Name
        { 
           get { return _name; } 
           set { _name = value; } 
        }


        public int Age
        { 
            get { return _age; } 
            set { _age = value; } 
        }

        public int DNI
        {
            get { return _dni; }    
            set { _dni = value; }
        }


        
    }
}
