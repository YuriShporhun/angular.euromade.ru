import { Component, OnDestroy } from '@angular/core';
import { Subject } from 'rxjs/Subject';
import { OrderStage } from './models/OrderStage';

@Component({
    selector: 'order',
    templateUrl: './order.component.html',
    styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnDestroy {
    OrderStage = OrderStage;

    submitSubject: Subject<void> = new Subject();

    private orderStage: OrderStage = OrderStage.Contacts;

    Submit() {
        this.submitSubject.next();
    }

    Next() {
        switch (this.orderStage) {
            case OrderStage.Contacts:
                this.orderStage = OrderStage.Delivery;
                break;
            case OrderStage.Delivery:
                this.orderStage = OrderStage.Payment;
                break;
            case OrderStage.Payment:
                this.orderStage = OrderStage.Done;
                break;
            default: break;
        }
    }

    ngOnDestroy() {
        this.submitSubject.unsubscribe();
    }
}