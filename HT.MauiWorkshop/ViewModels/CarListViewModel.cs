using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HT.MauiWorkshop.Models;
using HT.MauiWorkshop.Pages;
using HT.MauiWorkshop.Repository;

namespace HT.MauiWorkshop.ViewModels;

public partial class CarListViewModel : BaseViewModel
{
    [ObservableProperty] List<Car> cars;
    
    private readonly ICarRepository _carRepository;
    
    public CarListViewModel(ICarRepository carRepository)
    {
        _carRepository = carRepository ?? throw new ArgumentNullException(nameof(carRepository));
    }

    public override async Task OnAppearing()
    {
        Cars = await _carRepository.GetCarsAsync();
    }
    
    [RelayCommand]
    private void GoToDetailsPage(Car car)
    {
        Shell.Current.GoToAsync($"{nameof(CarDetailsPage)}?carId={car.Id}");
    }
}