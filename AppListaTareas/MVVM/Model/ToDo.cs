
using System.ComponentModel;

namespace AppListaTareas.MVVM.Model
{
    public class ToDo : INotifyPropertyChanged
    {
        private string title;
        private string description;

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
        public string Image {  get; set; } 
        public bool Completed { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
