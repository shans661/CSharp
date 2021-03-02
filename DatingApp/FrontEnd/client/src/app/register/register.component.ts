import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { User } from '../Models/User';
import { AccountService } from '../services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  @Output() cancelRegister = new EventEmitter();
  userModel:any = {};
  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
  }

  register()
  {
    this.accountService.register(this.userModel).subscribe(response =>
      {
        console.log(response);
        this.cancelClick();
      },
      error => {
        console.log(error);
      });
  }

  cancelClick()
  {
    this.cancelRegister.emit(false);
  }

}
