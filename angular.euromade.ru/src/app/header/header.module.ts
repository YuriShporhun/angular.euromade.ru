import { NgModule } from "@angular/core";
import { TopHeaderComponent } from "./top-header/top-header.component";
import { HeaderComponent } from "./header.component";
import { MainHeaderComponent } from "./main-header/main-header.component";
import { MainMenu } from "./main-menu/main-menu.component";

@NgModule({
    declarations: [
        TopHeaderComponent,
        MainHeaderComponent,
        HeaderComponent,
        MainMenu
    ],
    imports: [

    ],
    exports: [
        HeaderComponent
    ]
})
export class HeaderModule {
}
