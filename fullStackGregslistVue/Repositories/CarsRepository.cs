namespace fullStackGregslistVue.Repositories;

public class CarsRepository
{
  private readonly IDbConnection _db;

  public CarsRepository(IDbConnection db)
  {
    _db = db;
  }

  internal Car createCar(Car carData)
  {
    string sql = @"
INSERT INTO cars
  (make, model, imgUrl, body, price, userId)
values
  (@make, @model, @imgUrl, @body, @price, @userId);
  SELECT LAST_INSERT_ID()
;";

    int id = _db.ExecuteScalar<int>(sql, carData);
    carData.Id = id;
    return carData;
  }

  internal List<Car> GetAllCars()
  {
    string sql = @"
SELECT *
FROM cars
;";
    List<Car> cars = _db.Query<Car>(sql).ToList();
    return cars;
  }

  internal Car GetOneCar(int carId)
  {
    string sql = @"
SELECT *
FROM cars
WHERE id = @carId
;";
    Car car = _db.Query<Car>(sql, new { carId }).FirstOrDefault();
    return car;
  }

  internal void DeleteCar(int carId)
  {
    string sql = @"
DELETE
FROM cars
WHERE id = @carId
LIMIT 1
;";
    _db.Execute(sql, new { carId });
  }

  internal void EditCar(Car oldCar)
  {
    string sql = @"
UPDATE cars
SET
make = @Make,
model = @Model,
imgUrl = @ImgUrl,
body = @Body,
price = @Price
WHERE id = @Id
;";
    _db.Execute(sql, oldCar);
  }
}
