import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Member } from '../Models/member';

@Injectable({
  providedIn: 'root'
})
export class MemberService {
  constructor(private httpClient: HttpClient) { }

  getMember(username){
    return this.httpClient.get<Member>(environment.apiUrl + "username/"+username);
  }

  getMembers(){
    return this.httpClient.get<Member[]>(environment.apiUrl + "users");
  }
}
