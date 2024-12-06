
using System.ComponentModel;

namespace AppListaTareas.MVVM.Model
{
    public class ToDo : INotifyPropertyChanged //notificar el momento en el que cambiemos las propiedades
    {
        private string title;
        private string description;
        private bool completed;
        private string image;

        public string Title
        {
            get => title;
            
            set
            {
                if (title != value) 
                { 
                    title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }
        public string Description
        {
            get => description; 
            
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }
        public string Image
        {
            get => image; 
            set
            {
                if (image != value)
                {
                    image = value;
                    OnPropertyChanged(nameof(Image));
                }
            }
        }
        public bool Completed
        {
            get => completed;
            set
            {
                if (completed != value)
                {
                    completed = value;
                    OnPropertyChanged(nameof(Completed));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
