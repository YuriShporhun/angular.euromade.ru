import { Component } from '@angular/core';
import { OrderStage } from './order-stage';

@Component({
    selector: 'order',
    templateUrl: './order.component.html',
    styleUrls: ['./order.component.css']
})
export class OrderComponent {
    OrderStage = OrderStage;

    private orderStage: OrderStage = OrderStage.Contacts;

}