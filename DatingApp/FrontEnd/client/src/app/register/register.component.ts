import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { User } from '../Models/User';
import { AccountService } from '../services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  @Output() cancelRegister = new EventEmitter();
  userModel: any = {};
  registerForm: FormGroup;


  constructor(private accountService: AccountService,
    private toastr: ToastrService, private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.initialiteForm();
  }

  initialiteForm() {

    this.registerForm = this.formBuilder.group(
      {
        gender: ['', Validators.required],
        knownAs: ['', Validators.required],
        dateOfBirth: ['', Validators.required],
        city: ['', Validators.required],
        country: ['', Validators.required],
        username: ['', Validators.required],
        password: new FormControl("", [Validators.required, Validators.minLength(4), Validators.maxLength(14)]),
        confirmpassword: new FormControl("", [Validators.required, this.matchValues('password')])
      }); 
    // this.registerForm = new FormGroup({
    //   username: new FormControl("", Validators.required),
    //   password: new FormControl("", [Validators.required, Validators.minLength(4), Validators.maxLength(14)]),
    //   confirmpassword: new FormControl("", [Validators.required, this.matchValues('password')])
    // });

    this.registerForm.controls.password.valueChanges.subscribe(() =>
    {
      this.registerForm.controls.confirmpassword.updateValueAndValidity();
    })
  }
  matchValues(matchTo: string): ValidatorFn {
    return (control: AbstractControl) => { return control?.value === control?.parent?.controls[matchTo].value ? null : { isMatching: true } };
  }
  register() {
    this.accountService.register(this.userModel).subscribe(response => {
      console.log(response);
      this.cancelClick();
    },
      error => {
        console.log(error);
        this.toastr.error(error.error);
      });
  }

  cancelClick() {
    this.cancelRegister.emit(false);
  }

}
