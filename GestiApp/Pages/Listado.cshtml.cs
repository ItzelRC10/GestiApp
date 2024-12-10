using GestiApp.Models;
using GestiApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GestiApp.Pages
{
    public class ListadoModel : PageModel
    {
        private readonly ServicioTarea STObj;

        public List<Tarea> Tareas { get; set; }

        public ListadoModel(ServicioTarea servicio)
        {
            STObj = servicio;
        }

        public void OnGet()
        {
            Tareas = STObj.ObtenerTareas();
        }

        //Acci�n de completar la tarea
        public IActionResult OnPostCompletar(int id)
        {
            if (STObj.CompletarTarea(id))
            {
                TempData["Mensaje"] = "La tarea se complet� correctamente.";
            }
            else
            {
                TempData["Mensaje"] = "No se pudo completar la tarea.";
            }
            return RedirectToPage();
        }

        //Acci�n de eliminar la tarea
        public IActionResult OnPostEliminar(int id)
        {
            if (STObj.EliminarTarea(id))
            {
                TempData["Mensaje"] = "La tarea se elimin� correctamente.";
            }
            else
            {
                TempData["Mensaje"] = "No se pudo eliminar la tarea.";
            }
            return RedirectToPage();
        }
    }
}
