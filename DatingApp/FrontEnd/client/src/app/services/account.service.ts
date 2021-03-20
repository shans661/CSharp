import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import {map} from 'rxjs/operators';
import {User} from '../Models/User';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl = "https://localhost:5001/api/";
  private currentUserSource = new ReplaySubject<User>(1);
  currentUser$ = this.currentUserSource.asObservable();

  constructor(private http: HttpClient) { }

  login(model:any)
  {
      return this.http.post(this.baseUrl + 'login', model).pipe(
        map((response : User) =>
        {
          if(response)
          {
            localStorage.setItem("user", JSON.stringify(response));
            this.currentUserSource.next(response);
          }
        })
      );
  }

  register(model: any)
  {
      return this.http.post(this.baseUrl + 'register', model).pipe(
        map(response =>
          {
            if(response)
            {
              return response;
            }
          }
      ));
  }

  error()
  {
      return this.http.get(this.baseUrl + 'error').pipe(
        map(response =>
          {
            if(response)
            {
              return response;
            }
          }
      ));
  }

  setCurrentUser(user: User)
  {
    this.currentUserSource.next(user);
  }

  logout()
  {
    localStorage.removeItem("user");
    this.currentUserSource.next(null);
  }
}
