import { NgModule } from "@angular/core";
import { OrderComponent } from "./order.component";
import { CommonModule } from "@angular/common";
import { ContactsFormComponent } from "./contacts-form/contacts-form.component";

@NgModule({
    declarations: [
        OrderComponent,
        ContactsFormComponent
    ],
    imports: [
        CommonModule
    ],
    exports: [
        OrderComponent
    ]
})
export class OrderModule {
}
