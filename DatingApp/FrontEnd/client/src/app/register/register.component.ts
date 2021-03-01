import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { User } from '../Models/User';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  @Output() cancelRegister = new EventEmitter();
  userModel:any = {};
  constructor() { }

  ngOnInit(): void {
  }

  cancelClick()
  {
    this.cancelRegister.emit(false);
  }

}
