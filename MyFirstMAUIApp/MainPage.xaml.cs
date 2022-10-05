using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}

