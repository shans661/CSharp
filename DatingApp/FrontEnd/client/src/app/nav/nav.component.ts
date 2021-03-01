import { Component, OnInit } from '@angular/core';
import { User } from '../Models/User';
import { AccountService } from '../services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  constructor(public accountservice: AccountService) { }
  model: any = {};

  ngOnInit(): void {
  }

  setCurrentUser()
  {
    const user: User = JSON.parse(localStorage.getItem("user"));
    this.accountservice.setCurrentUser(user);
  }
  login()
  {
    this.accountservice.login(this.model).subscribe(response => {
      console.log(response);
    },
    error =>
    {
      console.log(error)
    });
  }

  logout()
  {
    this.accountservice.logout();
  }

}
