using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GestiApp.Pages
{
    public class IndexModel : PageModel
    {
        public string ObtenerSaludo()
        {
            var hora = DateTime.Now.Hour;

            if (hora < 12)
            {
                return "¡Buenos días!";
            }
            else if (hora < 18)
            {
                return "¡Buenas tardes!";
            }
            else
            {
                return "¡Buenas noches!";
            }
        }
    }
}
