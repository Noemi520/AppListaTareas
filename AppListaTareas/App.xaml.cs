using AppListaTareas.MVVM.View;

namespace AppListaTareas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage =new NavigationPage( new DataViewToDo());
        }
    }
}
