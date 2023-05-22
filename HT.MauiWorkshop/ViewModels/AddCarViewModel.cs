using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace HT.MauiWorkshop.ViewModels;

public class AddCarViewModel : BaseViewModel
{
    private string _make;
    private string _model;
    private string _year;
    private string _price;

    public string Make
    {
        get => _make;
        set
        {
            if (SetField(ref _make, value))
            {
                ((Command)AddCarCommand).ChangeCanExecute();
            }
        }
    }

    public string Model
    {
        get => _model;
        set
        {
            if (SetField(ref _model, value))
            {
                ((Command)AddCarCommand).ChangeCanExecute();
            }
        }
    }

    public string Year
    {
        get => _year;
        set
        {
            if (SetField(ref _year, value))
            {
                ((Command)AddCarCommand).ChangeCanExecute();
            }
        }
    }

    public string Price
    {
        get => _price;
        set
        {
            if (SetField(ref _price, value))
            {
                ((Command)AddCarCommand).ChangeCanExecute();
            }
        }
    }

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

    public ICommand AddCarCommand { get; }

    public AddCarViewModel()
    {
        AddCarCommand = new Command(AddCar, CanAddCar);
    }

    private bool CanAddCar() => !string.IsNullOrWhiteSpace(Make) && !string.IsNullOrWhiteSpace(Model) &&
                                !string.IsNullOrWhiteSpace(Year) && !string.IsNullOrWhiteSpace(Price);

    private void AddCar()
    {
        //Hello there
        var a = 10;
    }
}