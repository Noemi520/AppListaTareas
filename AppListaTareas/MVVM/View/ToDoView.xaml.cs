
using AppListaTareas.MVVM.Model;
using AppListaTareas.MVVM.ViewModel;

namespace AppListaTareas.MVVM.View;

public partial class ToDoView : ContentPage
{
	public ToDoView(ToDo todo)
	{
		InitializeComponent();
		BindingContext=new ToDoViewModel(todo);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}