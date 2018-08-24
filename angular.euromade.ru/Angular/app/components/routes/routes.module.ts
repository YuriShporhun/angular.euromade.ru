import { NgModule } from "@angular/core";
import { MainPageComponent } from "./main-page/main-page.component";
import { AboutComponent } from "./about/about.component";
import { ContactsComponent } from "./contacts/contacts.component";
import { DeliveryComponent } from "./delivery/delivery.component";
import { PaymentComponent } from "./payment/payment.component";

@NgModule({
    declarations: [
        MainPageComponent,
        AboutComponent,
        ContactsComponent,
        DeliveryComponent,
        PaymentComponent
    ],
    imports: [

    ],
    exports: [
        MainPageComponent,
        AboutComponent,
        ContactsComponent,
        DeliveryComponent,
        PaymentComponent
    ]
})
export class RoutesModule {
}
