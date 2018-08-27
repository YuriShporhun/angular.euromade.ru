import { Component, ViewChild, Input, Output, EventEmitter, OnInit, OnDestroy } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Subject } from 'rxjs/Subject';
import { BaseOrderForm } from '../models/BaseOrderForm';

@Component({
    selector: 'contacts-form',
    templateUrl: './contacts-form.component.html',
    styleUrls: ['./contacts-form.component.css']
})
export class ContactsFormComponent extends BaseOrderForm {
}