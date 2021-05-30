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
  memberCache = new Map();

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

    var response = this.memberCache.get(Object.values(userParams).join('-'));

    if(response)
    {
      return of(response);
    }

    let params = new HttpParams();

    if(userParams)
    {
      params = params.append('pageNumber', userParams.pageNumber.toString());
      params = params.append('pageSize', userParams.pageSize.toString());
      params = params.append('gender', userParams.gender.toString());
      params = params.append('minAge', userParams.minAge.toString());
      params = params.append('maxAge', userParams.maxAge.toString());
      params = params.append('orderBy', userParams.orderBy);
    }
    return this.httpClient.get<Member[]>(environment.apiUrl + "users", {observe : 'response', params}).pipe(
      map(response => {
        this.paginatedResult.result = response.body;
        if(response.headers.get('Pagination') !== null)
        {
          this.paginatedResult.pagination = JSON.parse(response.headers.get('Pagination'));
        }
        this.memberCache.set(Object.values(userParams).join('-'), {...this.paginatedResult});
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
