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

}