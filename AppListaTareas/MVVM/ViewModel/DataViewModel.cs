
using AppListaTareas.MVVM.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace AppListaTareas.MVVM.ViewModel
{
    public class DataViewModel
    {
        
        public ObservableCollection<ToDo> ToDos { get; set; } 

        public DataViewModel() 
        {
            ToDos = new ObservableCollection<ToDo>
            {
                new ToDo
                {
                    Title = "Comprar",
                    Description = "Hacer la compra mensual de la despensa",
                    Image = "carrito_supermercado.png",
                    HasPriority = true,

                },
                new ToDo
                {
                    Title="Medico",
                    Description="Pedir cita para anallisis de sangre",
                    Image="equipo_medico.png",
                    HasPriority = false,
                }

            };
        
        
        }
        public ICommand DeleteCommand => new Command((todo) =>
        {
            if (todo is ToDo)
            {
                ToDos.Remove((ToDo)todo);
            }

        });






    }
}
