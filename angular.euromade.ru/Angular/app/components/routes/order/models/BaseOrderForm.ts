import { NgForm } from "@angular/forms";
import { ViewChild, Input, Output, EventEmitter, OnInit, OnDestroy } from "@angular/core";
import { Subject } from "rxjs/Subject";

export abstract class BaseOrderForm implements OnInit {
    @ViewChild('form') form: NgForm;
    @Input() submitSubject: Subject<void>;
    @Output() formValidated = new EventEmitter();
    submitted: boolean = false;

    Submit() {
        this.submitted = true;
        if (this.form.valid) {
            this.formValidated.emit();
        }
    }

    ngOnInit() {
        this.submitSubject.subscribe(() => {
            this.form.ngSubmit.emit();
        });
    } 
}