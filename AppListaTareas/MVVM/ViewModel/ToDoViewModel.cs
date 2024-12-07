

using AppListaTareas.MVVM.Model;
using System.ComponentModel;

namespace AppListaTareas.MVVM.ViewModel
{
    public class ToDoViewModel : INotifyPropertyChanged
    {
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
                }
            }
        }

        public ToDoViewModel (ToDo todo) 
        { 
            SelectedToDo = todo;
        }




        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
