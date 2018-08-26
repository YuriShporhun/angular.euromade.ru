import { Injectable } from "@angular/core";
import { Cart } from "./cart";
import { Delivery } from "./delivery";
import { Payment } from "./payment";

@Injectable()
export class Order {
    firstName: string = '';
    secondName: string = '';
    email: string = '';
    phone: string = '';
    city: string = '';
    street: string = '';
    house: string = '';
    block: string = '';
    appartment: string = '';

    constructor(private cart: Cart, private delivery: Delivery, private payment: Payment) { }
}