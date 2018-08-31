import { NgModule } from "@angular/core";
import { MainPageComponent } from "./main-page/main-page.component";
import { AboutComponent } from "./about/about.component";
import { ContactsComponent } from "./contacts/contacts.component";
import { DeliveryComponent } from "./delivery/delivery.component";
import { PaymentComponent } from "./payment/payment.component";
import { OrderComponent } from "./order/order.component";
import { OrderModule } from "./order/order.module";
import { ShowcaseComponent } from "./main-page/showcase/showcase.component";

@NgModule({
    declarations: [
        MainPageComponent,
        AboutComponent,
        ContactsComponent,
        DeliveryComponent,
        PaymentComponent,
        ShowcaseComponent
    ],
    imports: [

    ],
    exports: [
        MainPageComponent,
        AboutComponent,
        ContactsComponent,
        DeliveryComponent,
        PaymentComponent,
        OrderModule
    ]
})
export class RoutesModule {
}
