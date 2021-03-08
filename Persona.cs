using System;

namespace Personas
{
    class Persona
    {
      public  string nombre;
       public string apellido;
        //Metodo sin void/string/int/etc.
        //Se llama igual que la clase
        // Metodo constructor
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public void Presentarse()
        {
            //Console.WriteLine("Hola, mi nombre es " + this.nombre + " " + this.apellido);
            Console.WriteLine($"Hola mi nombre es {this.nombre} {this.apellido}");
        }
    }
}