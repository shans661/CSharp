import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Member } from '../Models/member';

@Injectable({
  providedIn: 'root'
})
export class MemberService {

  members: Member[] = [];
  constructor(private httpClient: HttpClient) { }

  getMember(username){
    let member = this.members.find(x => x.userName === username);

    if(member)
    {
      return of(member);
    }
    return this.httpClient.get<Member>(environment.apiUrl + "username/"+username);
  }

  getMembers(){
    if(this.members.length > 0)
    {
      return of(this.members);
    }
    return this.httpClient.get<Member[]>(environment.apiUrl + "users").pipe(
      map(response => {
        this.members = response;
        return this.members;
      })
    );
  }

  updateMember(member: Member){
    return this.httpClient.put(environment.apiUrl+"update", member).pipe(
      map(() =>
      {
        let index = this.members.indexOf(member);
        this.members[index] = member;
      })
    );
  }
}
