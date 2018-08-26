import { Component } from '@angular/core';

enum OrderStage {
    Contacts,
    Delivery,
    Payment
}

@Component({
    selector: 'order',
    templateUrl: './order.component.html',
    styleUrls: ['./order.component.css']
})
export class OrderComponent {
    private orderStage: OrderStage = OrderStage.Contacts;

}