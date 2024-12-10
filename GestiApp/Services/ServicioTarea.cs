using GestiApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace GestiApp.Services
{
    public class ServicioTarea
    {
        private static List<Tarea> tareas = new List<Tarea>();

        //Método para obtener todas las tareas
        public List<Tarea> ObtenerTareas()
        {
            return tareas;
        }


        //Método para agregar una nueva tarea
        public void AgregarTarea(Tarea nuevaTarea)
        {
            nuevaTarea.Id = tareas.Count + 1;
            tareas.Add(nuevaTarea);
        }


        //Método para obtener una tarea por ID
        public Tarea ObtenerTareaPorId(int id)
        {
            return tareas.FirstOrDefault(t => t.Id == id); //Retorna la tarea o null si no se encuentra
        }


        //Método para actualizar una tarea existente
        public void ActualizarTarea(Tarea tareaEditada)
        {
            var tareaExistente = tareas.FirstOrDefault(t => t.Id == tareaEditada.Id);
            if (tareaExistente != null)
            {
                // Actualizar los valores de la tarea existente
                tareaExistente.Nombre = tareaEditada.Nombre;
                tareaExistente.FechaInicio = tareaEditada.FechaInicio;
                tareaExistente.Completada = tareaEditada.Completada;
            }
        }

        //Método para completar una tarea
        public bool CompletarTarea(int id)
        {
            var tarea = tareas.FirstOrDefault(t => t.Id == id);
            if (tarea != null)
            {
                tarea.Completada = true;
                return true;
            }
            return false;
        }

        //Método para eliminar una tarea
        public bool EliminarTarea(int id)
        {
            var tarea = tareas.FirstOrDefault(t => t.Id == id);
            if (tarea != null)
            {
                tareas.Remove(tarea);
                return true;
            }
            return false;
        }
    }
}
