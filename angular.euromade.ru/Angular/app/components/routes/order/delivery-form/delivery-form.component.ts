import { Component, ViewChild, Input, EventEmitter, Output, OnInit, OnDestroy } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Subject } from 'rxjs/Subject';
import { BaseOrderForm } from '../models/BaseOrderForm';

@Component({
    selector: 'delivery-form',
    templateUrl: './delivery-form.component.html',
    styleUrls: ['./delivery-form.component.css']
})
export class DeliveryFormComponent extends BaseOrderForm {
}