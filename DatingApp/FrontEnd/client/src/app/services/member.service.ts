import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Member } from '../Models/member';
import { PaginatedResult } from '../Models/pagination';
import { UserParams } from '../Models/userParams';

@Injectable({
  providedIn: 'root'
})
export class MemberService {

  members: Member[] = [];
  paginatedResult : PaginatedResult<Member[]> = new PaginatedResult<Member[]>();

  constructor(private httpClient: HttpClient) { }

  getMember(username){
    let member = this.members.find(x => x.userName === username);

    if(member)
    {
      return of(member);
    }
    return this.httpClient.get<Member>(environment.apiUrl + "username/"+username);
  }

  getMembers(userParams: UserParams){
    let params = new HttpParams();

    if(userParams)
    {
      params = params.append('pageNumber', userParams.pageNumber.toString());
      params = params.append('pageSize', userParams.pageSize.toString());
    }
    return this.httpClient.get<Member[]>(environment.apiUrl + "users", {observe : 'response', params}).pipe(
      map(response => {
        this.paginatedResult.result = response.body;
        if(response.headers.get('Pagination') !== null)
        {
          this.paginatedResult.pagination = JSON.parse(response.headers.get('Pagination'));
        }

        return this.paginatedResult;
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
