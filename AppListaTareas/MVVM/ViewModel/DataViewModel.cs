
using AppListaTareas.MVVM.Model;
using System.Collections.ObjectModel;


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
                    Image = "carrito-de-supermercado.png",
                    HasPriority = true,

                }

            };
        
        
        }
            

            
        
       

    }
}
