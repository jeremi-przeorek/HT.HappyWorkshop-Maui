namespace HT.MauiWorkshop.Pages;

public partial class AddCarPage : ContentPage
{
	public AddCarPage()
	{
		InitializeComponent();

		Picker.Items.Add("Tesla");
		Picker.Items.Add("Ford");
		Picker.Items.Add("GM");
		Picker.Items.Add("Toyota");
		Picker.Items.Add("Honda");
	}
}


