using System;

namespace alumnos
{
    class Alumno : Persona //La clase alumno hereda a Persona para tomar nombre, apellido
    {
      public string matricula; //variable matricula agregada

      public Alumno(string nombre, string apellido, string matricula) : base(nombre, apellido)
      {
          this.matricula = matricula;
      }
    }
}