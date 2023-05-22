using CommunityToolkit.Mvvm.ComponentModel;
using HT.MauiWorkshop.Models;
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
}