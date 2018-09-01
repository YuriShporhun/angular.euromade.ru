import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'round-button',
    templateUrl: './round-button.component.html',
    styleUrls: ['./round-button.component.css'],
})
export class RoundButtonComponent {
    @Input() color: string = '#ffffff';
    @Input() link: string = 'main-page';
    @Input() text: string = '<ERROR>';

    constructor(private router: Router) { }

    click() {
        this.router.navigateByUrl(this.link);
    }
}
