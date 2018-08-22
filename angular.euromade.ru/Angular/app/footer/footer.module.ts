import { NgModule } from "@angular/core";
import { FooterComponent } from "./footer.component";
import { ArticlesComponent } from "./articles/articles.component";
import { BottomFooterComponent } from "./bottom-footer/bottom-footer.component";
import { NewsComponent } from "./news/news.component";
import { SubscriptionComponent } from "./subscription/subscription.component";

@NgModule({
    declarations: [
        FooterComponent,
        ArticlesComponent,
        BottomFooterComponent,
        NewsComponent,
        SubscriptionComponent
    ],
    imports: [

    ],
    exports: [
        FooterComponent
    ]
})
export class FooterModule {
}
