import { NgModule } from "@angular/core";
import { MainPageComponent } from "./main-page/main-page.component";
import { AboutComponent } from "./about/about.component";
import { ContactsComponent } from "./contacts/contacts.component";
import { DeliveryComponent } from "./delivery/delivery.component";
import { PaymentComponent } from "./payment/payment.component";
import { OrderModule } from "./order/order.module";
import { ShowcaseComponent } from "./main-page/showcase/showcase.component";
import { SharedComponentsModule } from "../shared/shared.module";
import { SectionsComponent } from "./main-page/sections/sections.component";
import { RecommendationsComponent } from "./main-page/recommendations/recommendations.component";

@NgModule({
    declarations: [
        MainPageComponent,
        AboutComponent,
        ContactsComponent,
        DeliveryComponent,
        PaymentComponent,
        ShowcaseComponent,
        SectionsComponent,
        RecommendationsComponent
    ],
    imports: [
        SharedComponentsModule
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
