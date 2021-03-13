import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { User } from '../Models/User';
import { AccountService } from '../services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  constructor(public accountservice: AccountService, private route: Router,
    private toastr: ToastrService) { }
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
      this.route.navigateByUrl('/members');
    },
    error =>
    {
      console.log(error);
      this.toastr.error(error.error);
    });
  }

  logout()
  {
    this.accountservice.logout();
    this.route.navigateByUrl('/');
  }

}
