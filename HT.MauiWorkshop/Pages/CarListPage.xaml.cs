using HT.MauiWorkshop.ViewModels;

namespace HT.MauiWorkshop.Pages;

public partial class CarListPage : ContentPage
{
	public CarListPage(CarListViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	protected override void OnAppearing()
	{
		(BindingContext as BaseViewModel)?.OnAppearing();
	}
}
