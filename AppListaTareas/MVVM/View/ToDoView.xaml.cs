
using AppListaTareas.MVVM.Model;
using AppListaTareas.MVVM.ViewModel;

namespace AppListaTareas.MVVM.View;

public partial class ToDoView : ContentView
{
	public ToDoView(ToDo todo)
	{
		InitializeComponent();
		BindingContext=new ToDoViewModel(todo);
	}
}