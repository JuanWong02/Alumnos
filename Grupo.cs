using System; 
using System.Collections.Generic;

namespace alumnos
{
    class Grupo
    {
        public string nombre;
        
        public int semestre;

       List<Alumno> alumnos = new List<Alumno>();

       List<Materia> materias = new List<Materia>();    

        // Metodo para agregar alumno a la lista
       public void AgregarAlumno(Alumno alumno) 
       {
        alumnos.Add(alumno);
         
       }
        //Metodo para quitar alumno de la lista
        public void QuitarAlumno(Alumno alumno) 
       {
        alumnos.Remove(alumno);
         
       }
        //agregar materia a la lista
       public void AgregarMateria(Materia materia)
       {
           materias.Add(materia);
       }
        //quitar materia de la lista
       public void QuitarMateria(Materia materia)
       {
           materias.Remove(materia);
       }
    
      
    
    }

    
    
}