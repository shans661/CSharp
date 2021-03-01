import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  isRegisterMode = false;
  constructor() { }

  ngOnInit(): void {
  }

  register()
  {
    this.isRegisterMode = !this.isRegisterMode;
  }

  readmore()
  {
    console.log("Feature under implementation");
  }

  cancelRegister(event: boolean)
  {
      this.isRegisterMode = false;
  }

}
