import { NgModule } from "@angular/core";
import { TopHeaderComponent } from "./top-header/top-header.component";
import { HeaderComponent } from "./header.component";
import { MainHeaderComponent } from "./main-header/main-header.component";
import { MainMenu } from "./main-menu/main-menu.component";
import { GeolocationComponent } from "./geolocation/geolocation.component";
import { InfoButtonComponent } from "./info-button/info-button.component";

@NgModule({
    declarations: [
        TopHeaderComponent,
        MainHeaderComponent,
        HeaderComponent,
        MainMenu,
        GeolocationComponent,
        InfoButtonComponent
    ],
    imports: [

    ],
    exports: [
        HeaderComponent
    ]
})
export class HeaderModule {
}
