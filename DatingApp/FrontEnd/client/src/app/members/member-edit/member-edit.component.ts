import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { take } from 'rxjs/operators';
import { Member } from 'src/app/Models/member';
import { User } from 'src/app/Models/User';
import { AccountService } from 'src/app/services/account.service';
import { MemberService } from 'src/app/services/member.service';

@Component({
  selector: 'app-member-edit',
  templateUrl: './member-edit.component.html',
  styleUrls: ['./member-edit.component.css']
})
export class MemberEditComponent implements OnInit {

  @ViewChild('editForm') editForm: NgForm;
  member: Member;
  user: User;

  constructor(private accountService: AccountService, private memberService: MemberService) { 
  this.accountService.currentUser$.pipe(take(1)).subscribe(user => this.user = user)}

  ngOnInit(): void {
    this.loadMember();
  }

  loadMember()
  {
    this.memberService.getMember(this.user.username).subscribe(member => this.member = member);
  }

  updateMember()
  {
    console.log(this.member);
    this.editForm.reset(this.member);
  }
}
