namespace fullStackGregslistVue.Services;

public class CarsService
{
  private readonly CarsRepository _repo;

  public CarsService(CarsRepository repo)
  {
    _repo = repo;
  }

  internal Car createCar(Car carData)
  {
    Car car = _repo.createCar(carData);
    return car;
  }

  internal List<Car> GetAllCars()
  {
    List<Car> cars = _repo.GetAllCars();
    return cars;
  }

  internal Car GetOneCar(int carId)
  {
    Car car = _repo.GetOneCar(carId);
    if (car == null) throw new Exception($"The Car you are trying to get, with the ID: {carId}, does not exist!");
    return car;
  }
}
