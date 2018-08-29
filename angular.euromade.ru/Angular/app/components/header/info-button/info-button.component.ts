import { Component, Input } from '@angular/core';
import { trigger, state, style, transition, animate } from '@angular/animations';

@Component({
    selector: 'info-button',
    templateUrl: './info-button.component.html',
    styleUrls: ['./info-button.component.css'],
})
export class InfoButtonComponent {
    @Input() label: string;
    @Input() link: string;
}
