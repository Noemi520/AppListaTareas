
using AppListaTareas.MVVM.Model;
using AppListaTareas.MVVM.View;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;



namespace AppListaTareas.MVVM.ViewModel
{
    public class DataViewModel :INotifyPropertyChanged
    {
        
        public ObservableCollection<ToDo> ToDos { get; set; } =new ObservableCollection<ToDo>();

        private ToDo _selectedToDo;
        
        public ToDo SelectedToDo 
        {
            get => _selectedToDo;
            set
            {
                if (_selectedToDo != value)
                {
                    _selectedToDo = value;
                    OnPropertyChanged(nameof(SelectedToDo));
                    OnPropertyChanged(nameof(IsSelectedToDo));
                }
            }
        }
        public bool  IsSelectedToDo() => SelectedToDo != null;

        #region COMANDOS
        public ICommand addToDoCommand { get;  }
        public ICommand NavigationToDoCommand { get;  }
        public ICommand DeleteToDoCommand {  get;  }
        #endregion

        #region INICIALIZACION COMMAND
        public DataViewModel() 
        {
            addToDoCommand = new Command(AddToDo);
            NavigationToDoCommand = new Command<ToDo>(NavigationToDo);
            DeleteToDoCommand = new Command<ToDo>(DeleteToDo);
            ToDoList();
        }

        
        #endregion
        #region LISTA DE PRUEBA
        private void ToDoList()
        {
            ToDos.Add(new ToDo  //Cuidado!! Debemos agregar al ObservableCollection
            {
                Title = "Comprar",
                Description = "Hacer la compra mensual de la despensa",
                Image = "carrito_supermercado.png",
                Completed = true

            });
            ToDos.Add(new ToDo 
            {
                Title = "Veterinario",
                Description = "Vacuna de refuerzo de la rabia ",
                Image = "veterinario.png",
                Completed = false
            });
            ToDos.Add(new ToDo
            {
                Title = "Medico",
                Description = "Sacar sangre para analitica ",
                Image = "equipo_medico.png",
                Completed = false
            });
            ToDos.Add(new ToDo
            {
                Title = "Gimnasio",
                Description = "VNuevo proposito 2025 ",
                Image = "maquina_gimnasio.png",
                Completed = false
            });
            ToDos.Add(new ToDo
            {
                Title = "Farmacia",
                Description = "Coger medicación de alergia ",
                Image = "farmacia.png",
                Completed = true
            });
        }
        #endregion
        #region ANIADIR NUEVA TAREA

        private void AddToDo(object obj)
        {
            ToDos.Add(new ToDo
            {
                Title = "Nueva Tarea",
                Description = "Escribe lo que quieras ",
                Image = "agregar_tarea.png",
                Completed = false
            });
        }
        #endregion
        #region SACAR DETALLES DE LAS TAREAS
        private async void NavigationToDo(ToDo todo)
        {
            if (todo != null)
            {
                var toDoViewModel=new ToDoViewModel(todo);
                var toDoView = new ToDoView(todo)
                { 
                    BindingContext=toDoViewModel
                };
                await Application.Current.MainPage.Navigation.PushAsync(toDoView);
            }
        }
        #endregion  

        #region ELIMINAR TAREA
       private void DeleteToDo(ToDo @do)
        {
            if (@do != null)
            {
                ToDos.Remove(@do);
                if (SelectedToDo == @do)
                {
                    SelectedToDo = null;
                    OnPropertyChanged(nameof(IsSelectedToDo));
                }

            }
        }
        #endregion

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
