import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { take } from 'rxjs/operators';
import { Member } from 'src/app/Models/member';
import { Pagination } from 'src/app/Models/pagination';
import { User } from 'src/app/Models/User';
import { UserParams } from 'src/app/Models/userParams';
import { AccountService } from 'src/app/services/account.service';
import { MemberService } from 'src/app/services/member.service';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {

  constructor(private memberService: MemberService) {
    this.userParams = memberService.getUserParams();
  }

  members: Member[];
  pagination: Pagination;
  userParams: UserParams;
  genderList = [{ value: 'male', display: 'Male' }, { value: 'female', display: 'Female' }];
  orderByList = [{ value: 'lastActive', display: 'Last Active' }, { value: 'created', display: 'Created At' }];
  user: User;


  ngOnInit(): void {
    this.loadMembers();
  }

  loadMembers() {
    this.memberService.setUserparams(this.userParams);
    this.memberService.getMembers(this.userParams).subscribe(response => {
      this.members = response.result;
      this.pagination = response.pagination;
    })
  }

  pageChanged(event: any) {
    this.userParams.pageNumber = event.page;
    this.loadMembers();
  }

  resetFilter() {
    this.userParams = this.memberService.resetUserParam();
    this.loadMembers();
  }

}
