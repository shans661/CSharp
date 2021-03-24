import { Component, OnInit } from '@angular/core';
import { Member } from 'src/app/Models/member';
import { MemberService } from 'src/app/services/member.service';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {

  constructor(private memeberService: MemberService) { }

  members: Member[];

  ngOnInit(): void {
    this.loadMemebers();
  }

loadMemebers()
{
  this.memeberService.getMembers().subscribe(members => {
    this.members = members
  })
}

}
