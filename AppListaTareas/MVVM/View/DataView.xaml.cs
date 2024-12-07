
using AppListaTareas.MVVM.ViewModel;

namespace AppListaTareas.MVVM.View;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();
	}
}