using GestiApp.Models;
using GestiApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GestiApp.Pages
{
    public class EditarModel : PageModel
    {
        private readonly ServicioTarea STObj;

        public EditarModel(ServicioTarea servicioTarea)
        {
            STObj = servicioTarea;
        }

        [BindProperty]
        public Tarea Tarea { get; set; }

        public bool Guardado { get; set; }

        public IActionResult OnGet(int id)
        {
            //Obtener la tarea por ID usando el servicio
            Tarea = STObj.ObtenerTareaPorId(id);

            if (Tarea == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Actualizar la tarea usando el servicio
            STObj.ActualizarTarea(Tarea);
            Guardado = true; //Mostrar mensaje de confirmación
            return Page();
        }
    }
}
