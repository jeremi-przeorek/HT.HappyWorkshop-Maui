using HT.MauiWorkshop.Pages;

namespace HT.MauiWorkshop;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		
		Routing.RegisterRoute(nameof(CarDetailsPage), typeof(CarDetailsPage));
	}
}

