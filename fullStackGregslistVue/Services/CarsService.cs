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

  internal string DeleteCar(int carId, string userId)
  {
    Car car = GetOneCar(carId);
    if (car.UserId != userId) throw new Exception("You are not Authorized to delete this Car");
    _repo.DeleteCar(carId);
    return $"You have Deleted the Car with ID: {carId}";
  }

  internal Car EditCar(Car carData)
  {
    Car oldCar = GetOneCar(carData.Id);
    if (oldCar.UserId != carData.UserId) throw new Exception("You are not Authorized to edit this Car");

    oldCar.Make = carData.Make ?? oldCar.Make;
    oldCar.Model = carData.Model ?? oldCar.Model;
    oldCar.ImgUrl = carData.ImgUrl ?? oldCar.ImgUrl;
    oldCar.Body = carData.Body ?? oldCar.Body;
    oldCar.Price = carData.Price != null ? carData.Price : oldCar.Price;

    _repo.EditCar(oldCar);

    return oldCar;
  }
}
