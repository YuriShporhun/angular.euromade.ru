import { NgModule } from "@angular/core";
import { OrderComponent } from "./order.component";
import { CommonModule } from "@angular/common";
import { ContactsFormComponent } from "./contacts-form/contacts-form.component";
import { DeliveryFormComponent } from "./delivery-form/delivery-form.component";
import { FormsModule } from "@angular/forms";
import { PaymentFormComponent } from "./payment-form/payment-form.component";

@NgModule({
    declarations: [
        OrderComponent,
        ContactsFormComponent,
        DeliveryFormComponent,
        PaymentFormComponent
    ],
    imports: [
        CommonModule,
        FormsModule
    ],
    exports: [
        OrderComponent
    ]
})
export class OrderModule {
}
