using HT.MauiWorkshop.Models;

namespace HT.MauiWorkshop.Repository;

public interface ICarRepository
{
    Task<List<Car>> GetCarsAsync();
    Task AddCarAsync(Car car);
    Task DeleteCarAsync(Car car);
    Task UpdateCarAsync(Car car);
}