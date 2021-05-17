import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Member } from 'src/app/Models/member';
import { Pagination } from 'src/app/Models/pagination';
import { UserParams } from 'src/app/Models/userParams';
import { MemberService } from 'src/app/services/member.service';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {

  constructor(private memberService: MemberService) { }

  members: Member[];
  pagination : Pagination;
  userParams: UserParams;

  ngOnInit(): void {
    this.loadMembers();
  }

  loadMembers() {
    this.memberService.getMembers(this.userParams).subscribe(response =>
      {
        this.members = response.result;
        this.pagination = response.pagination;
      })
  }

  pageChanged(event : any)
  {
    this.userParams.pageNumber = event.page;
    this.loadMembers();
  }

}
