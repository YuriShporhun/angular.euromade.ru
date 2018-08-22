import { NgModule } from "@angular/core";
import { MainPageComponent } from "./main-page/main-page.component";
import { AboutComponent } from "./about/about.component";

@NgModule({
    declarations: [
        MainPageComponent,
        AboutComponent
    ],
    imports: [

    ],
    exports: [
        MainPageComponent,
        AboutComponent
    ]
})
export class RoutesModule {
}
