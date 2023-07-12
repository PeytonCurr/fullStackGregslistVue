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
}
