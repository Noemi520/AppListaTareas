
namespace AppListaTareas.MVVM.Model
{
    public class Task
    {
        public string Title {  get; set; }=string.Empty;
        public string Description {  get; set; }= string.Empty;
        public string Image {  get; set; } =string.Empty;
        public bool HasPriority { get; set; }
        public DateTime FechaRealizar { get; set; }
    }
}
