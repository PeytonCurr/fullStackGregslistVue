import { Profile } from "./Account.js"

export class Car {
  constructor(data) {
    this.id = data.id
    this.make = data.make
    this.model = data.model
    this.imgUrl = data.imgUrl
    this.body = data.body
    this.price = data.price
    this.description = data.description
    this.creatorId = data.creatorId
    this.seller = new Profile(data.seller)
  }
}