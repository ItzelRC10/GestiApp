using GestiApp.Models;
using GestiApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GestiApp.Pages
{
    public class AgregarModel : PageModel
    {
        private readonly ServicioTarea STObj;

        [BindProperty]
        public Tarea NuevaTarea { get; set; }

        public AgregarModel(ServicioTarea servicio)
        {
            STObj = servicio;
        }

        //Ejecucion del metodo cuando se envía el formulario
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Agregar la nueva tarea al servicio
            STObj.AgregarTarea(NuevaTarea);

            //Redireccionar a la lista de tareas después de agregar
            return RedirectToPage("/Listado");

        }
    }
}
