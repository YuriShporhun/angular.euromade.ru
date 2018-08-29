import { Injectable } from "@angular/core";
import { Http } from '@angular/http';
import { Subject } from "rxjs/Subject";

@Injectable()
export class GeolocationService {

    geoSubject: Subject<string> = new Subject<string>();

    constructor(private http: Http) {
        this.http.get('http://ipinfo.io')
            .subscribe((data: any) => {
                let ip = JSON.parse(data.text()).ip;
                this.http.get("http://api.sypexgeo.net/json/" + ip)
                    .subscribe((response: any) => {
                        this.geoSubject.next(JSON.parse(response.text()).city.name_ru)
                });
            });
    }
}