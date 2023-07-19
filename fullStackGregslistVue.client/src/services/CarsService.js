import { AppState } from "../AppState.js"
import { Car } from "../models/Car.js"
import { logger } from "../utils/Logger.js"
import { api } from "./AxiosService.js"

class CarsService {
  async getCars() {
    AppState.cars = []
    const res = await api.get("api/cars")
    logger.log(res.data)
    AppState.cars = res.data.map(c => new Car(c))
  }


}

export const carsService = new CarsService()