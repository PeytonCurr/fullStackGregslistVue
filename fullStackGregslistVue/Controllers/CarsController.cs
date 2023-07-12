namespace fullStackGregslistVue.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarsController : ControllerBase
{
  private readonly CarsService _carsService;
  private readonly Auth0Provider _auth;

  public CarsController(CarsService carsService, Auth0Provider auth)
  {
    _carsService = carsService;
    _auth = auth;
  }

  [HttpPost]
  [Authorize]
  public async Task<ActionResult<Car>> CreateCar([FromBody] Car carData)
  {
    try
    {
      Account userInfo = await _auth.GetUserInfoAsync<Account>(HttpContext);
      carData.UserId = userInfo.Id;
      Car car = _carsService.createCar(carData);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet]
  public ActionResult<List<Car>> GetAllCars()
  {
    try
    {
      List<Car> cars = _carsService.GetAllCars();
      return Ok(cars);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{carId}")]
  public ActionResult<Car> GetOneCar(int carId)
  {
    try
    {
      Car car = _carsService.GetOneCar(carId);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}
