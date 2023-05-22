using HT.MauiWorkshop.ViewModels;

namespace HT.MauiWorkshop.Pages;

public partial class AddCarPage : ContentPage
{
	public AddCarPage(AddCarViewModel vm)
	{
		InitializeComponent();
		
		BindingContext = vm;
	}
}


