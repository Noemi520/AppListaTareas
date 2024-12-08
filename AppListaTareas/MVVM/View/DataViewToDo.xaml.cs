
using AppListaTareas.MVVM.ViewModel;

namespace AppListaTareas.MVVM.View;

public partial class DataViewToDo : ContentPage
{
	public DataViewToDo()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();

        NavigationPage.SetHasNavigationBar(this, false);
    }
}