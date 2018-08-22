import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HeaderModule } from './header/header.module';
import { AsideModule } from './aside/aside.module';
import { FooterModule } from './footer/footer.module';
import { MainPageComponent } from './routes/main-page/main-page.component';
import { RoutesModule } from './routes/routes.module';
import { AboutComponent } from './routes/about/about.component';

@NgModule({
    declarations: [
        AppComponent
    ],
    imports: [
        HeaderModule,
        AsideModule,
        FooterModule,
        RoutesModule,
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'main-page', pathMatch: 'full' },
            { path: 'main-page', component: MainPageComponent },
            { path: 'about', component: AboutComponent },
            { path: '**', redirectTo: 'main-page' }
        ])
    ]
})
export class AppModuleShared {
}
