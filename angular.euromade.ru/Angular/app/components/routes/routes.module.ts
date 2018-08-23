import { NgModule } from "@angular/core";
import { MainPageComponent } from "./main-page/main-page.component";
import { AboutComponent } from "./about/about.component";
import { ContactsComponent } from "./contacts/contacts.component";

@NgModule({
    declarations: [
        MainPageComponent,
        AboutComponent,
        ContactsComponent
    ],
    imports: [

    ],
    exports: [
        MainPageComponent,
        AboutComponent,
        ContactsComponent
    ]
})
export class RoutesModule {
}
