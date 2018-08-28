import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { HeaderModule } from './components/header/header.module';
import { AsideModule } from './components/aside/aside.module';
import { FooterModule } from './components/footer/footer.module';
import { MainPageComponent } from './components/routes/main-page/main-page.component';
import { RoutesModule } from './components/routes/routes.module';
import { AboutComponent } from './components/routes/about/about.component';
import { ContactsComponent } from './components/routes/contacts/contacts.component';
import { DeliveryComponent } from './components/routes/delivery/delivery.component';
import { PaymentComponent } from './components/routes/payment/payment.component';
import { OrderComponent } from './components/routes/order/order.component';
import { BrowserModule } from '@angular/platform-browser';

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
        BrowserModule,

        RouterModule.forRoot([
            { path: '', redirectTo: 'main-page', pathMatch: 'full' },
            { path: 'main-page', component: MainPageComponent },
            { path: 'about', component: AboutComponent },
            { path: 'contacts', component: ContactsComponent },
            { path: 'delivery', component: DeliveryComponent },
            { path: 'payment', component: PaymentComponent },
            { path: 'order', component: OrderComponent },
            { path: '**', redirectTo: 'main-page' }
        ])
    ]
})
export class AppModuleShared {
}
