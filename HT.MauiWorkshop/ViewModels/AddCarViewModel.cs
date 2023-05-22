using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HT.MauiWorkshop.Models;
using HT.MauiWorkshop.Repository;

namespace HT.MauiWorkshop.ViewModels;

public partial class AddCarViewModel : BaseViewModel
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(AddCarCommand))]
    private string make;
    
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(AddCarCommand))]
    private string model;
    
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(AddCarCommand))]
    private string year;
    
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(AddCarCommand))]
    private string price;

    private readonly ICarRepository _carRepository;

    public List<string> Makes { get; set; } = new List<string>()
    {
        "Tesla", "Ford", "Chevrolet", "Toyota", "Honda", "Nissan", "BMW",
        "Mercedes-Benz", "Audi", "Volkswagen", "Hyundai", "Kia", "Volvo", "Mazda", "Subaru", "Jeep", "GMC", "Lexus",
        "Cadillac", "Buick", "Lincoln", "Chrysler", "Porsche", "Acura", "Infiniti", "Land Rover", "Mitsubishi", "Mini",
        "Jaguar", "Fiat", "Ram", "Bentley", "Scion", "Maserati", "Ferrari", "Smart", "Tesla", "Aston Martin", "Suzuki",
        "Lamborghini", "Lotus", "Rolls-Royce", "Bugatti", "Genesis", "Hummer", "Pontiac", "Saturn", "Saab",
        "Oldsmobile", "Mercury", "Plymouth", "Daewoo", "Aston Martin", "MG", "Alfa Romeo", "Acura", "AMC", "Audi",
        "Austin", "Austin-Healey", "Bentley", "BMW", "Bugatti", "Buick", "Cadillac", "Chevrolet"
    };

    private bool CanAddCar =>
        !string.IsNullOrWhiteSpace(Make) && !string.IsNullOrWhiteSpace(Model) &&
        !string.IsNullOrWhiteSpace(Year) && !string.IsNullOrWhiteSpace(Price);

    public AddCarViewModel(ICarRepository carRepository)
    {
        _carRepository = carRepository ?? throw new ArgumentNullException(nameof(carRepository));
    }

    [RelayCommand(CanExecute = nameof(CanAddCar))]
    private async Task AddCar()
    {
        try
        {
            await _carRepository.AddCarAsync(new Car(null, Make, Model, Year, Price));
        }
        catch (Exception e)
        {
            await Shell.Current.DisplayAlert("Error", e.Message, "Ok");
        }
    }
}