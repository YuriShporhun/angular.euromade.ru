import { Injectable } from "@angular/core";
import { Http } from '@angular/http';

@Injectable()
export class GeolocationService {
    constructor(private http: Http) {
        this.http.get('https://jsonip.com')
            .subscribe((data: any) => {
                this.http.get("http://api.sypexgeo.net/json/" + data.ip)
                    .subscribe((response: any) => {
                        console.log(response);
                    });
            });
    }
}