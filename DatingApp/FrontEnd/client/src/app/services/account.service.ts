import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import {map} from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import {User} from '../Models/User';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  private currentUserSource = new ReplaySubject<User>(1);
  currentUser$ = this.currentUserSource.asObservable();

  constructor(private http: HttpClient) { }

  login(model:any)
  {
      return this.http.post(environment.apiUrl + 'login', model).pipe(
        map((response : User) =>
        {
          if(response)
          {
            this.setCurrentUser(response);
          }
        })
      );
  }

  register(model: any)
  {
      return this.http.post(environment.apiUrl + 'register', model).pipe(
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
      return this.http.get(environment.apiUrl + 'error').pipe(
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
    localStorage.setItem("user", JSON.stringify(user));
    this.currentUserSource.next(user);
  }

  logout()
  {
    localStorage.removeItem("user");
    this.currentUserSource.next(null);
  }
}
