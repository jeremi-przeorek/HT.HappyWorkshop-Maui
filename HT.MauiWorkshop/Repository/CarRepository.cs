using HT.MauiWorkshop.Models;
using SQLite;

namespace HT.MauiWorkshop.Repository;

public class CarRepository : ICarRepository
{
    private readonly SQLiteAsyncConnection _connection;

    public CarRepository(ISqliteConnection sqliteConnection)
    {
        _connection = sqliteConnection.GetAsyncConnection("cars.db");
        _connection.CreateTableAsync<CarEntity>();
    }

    public async Task<List<Car>> GetCarsAsync()
    {
        var cars = await _connection.Table<CarEntity>().ToListAsync();
        return cars.Select(x => new Car(x.Id,x.Make, x.Model, x.Year, x.Price)).ToList();
    }
    
    public async Task AddCarAsync(Car car)
    {
        var carEntity = new CarEntity
        {
            Make = car.Make,
            Model = car.Model,
            Year = car.Year,
            Price = car.Price
        };
        await _connection.InsertAsync(carEntity);
    }
    
    public async Task DeleteCarAsync(Car car)
    {
        await _connection.DeleteAsync(car.Id);
    }
    
    public async Task UpdateCarAsync(Car car)
    {
        if (car.Id == null)
        {
            throw new ArgumentException("Car Id cannot be null");
        }
        
        var carEntity = new CarEntity
        {
            Id = (int)car.Id,
            Make = car.Make,
            Model = car.Model,
            Year = car.Year,
            Price = car.Price
        };
        await _connection.UpdateAsync(carEntity);
    }
}