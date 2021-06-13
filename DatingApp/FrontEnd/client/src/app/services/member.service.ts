import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { map, take } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Member } from '../Models/member';
import { PaginatedResult } from '../Models/pagination';
import { User } from '../Models/User';
import { UserParams } from '../Models/userParams';
import { AccountService } from './account.service';

@Injectable({
  providedIn: 'root'
})
export class MemberService {

  members: Member[] = [];
  paginatedResult: PaginatedResult<Member[]> = new PaginatedResult<Member[]>();
  memberCache = new Map();
  user: User;
  userParams: UserParams;

  constructor(private httpClient: HttpClient, accountService: AccountService) {
    accountService.currentUser$.pipe(take(1)).subscribe(response => {
      this.user = response,
        this.userParams = new UserParams(response);
    });
  }

  setUserparams(param: UserParams) {
    this.userParams = param;
  }

  getUserParams() {
    return this.userParams;
  }

  resetUserParam() {
    this.userParams = new UserParams(this.user);
    return this.userParams;
  }

  getMember(username) {
    const member = [...this.memberCache.values()]
      .reduce((arr, elem) => arr.concat(elem.result), [])
      .find((x: Member) => x.userName === username);

    if (member) {
      return of(member);
    }
    return this.httpClient.get<Member>(environment.apiUrl + "username/" + username);
  }

  getMembers(userParams: UserParams) {

    var response = this.memberCache.get(Object.values(userParams).join('-'));

    if (response) {
      return of(response);
    }

    let params = new HttpParams();

    if (userParams) {
      params = params.append('pageNumber', userParams.pageNumber.toString());
      params = params.append('pageSize', userParams.pageSize.toString());
      params = params.append('gender', userParams.gender.toString());
      params = params.append('minAge', userParams.minAge.toString());
      params = params.append('maxAge', userParams.maxAge.toString());
      params = params.append('orderBy', userParams.orderBy);
    }
    return this.httpClient.get<Member[]>(environment.apiUrl + "users", { observe: 'response', params }).pipe(
      map(response => {
        this.paginatedResult.result = response.body;
        if (response.headers.get('Pagination') !== null) {
          this.paginatedResult.pagination = JSON.parse(response.headers.get('Pagination'));
        }
        this.memberCache.set(Object.values(userParams).join('-'), { ...this.paginatedResult });
        return this.paginatedResult;
      })
    );
  }

  updateMember(member: Member) {
    return this.httpClient.put(environment.apiUrl + "update", member).pipe(
      map(() => {
        let index = this.members.indexOf(member);
        this.members[index] = member;
      })
    );
  }

  addLike(username: string) {
    return this.httpClient.post(environment.apiUrl + "like/" + username, {});
  }

  getLikes(predicte: string) {
    return this.httpClient.get<Partial<Member[]>>(environment.apiUrl + "like?predicate=" + predicte);
  }
}
