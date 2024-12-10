namespace GestiApp.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public bool Completada { get; set; } = false;
    }
}
