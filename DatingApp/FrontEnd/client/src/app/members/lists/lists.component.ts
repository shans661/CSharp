import { Component, OnInit } from '@angular/core';
import { Member } from 'src/app/Models/member';
import { MemberService } from 'src/app/services/member.service';

@Component({
  selector: 'app-lists',
  templateUrl: './lists.component.html',
  styleUrls: ['./lists.component.css']
})
export class ListsComponent implements OnInit {

  members: Partial<Member[]>;
  liked = 'liked';
  likedBy = 'likedBy';
  constructor(private memberService: MemberService) { }

  ngOnInit(): void {
    this.loadLikes(this.liked);
  }

  loadLikes(predicate: string){
    this.memberService.getLikes(predicate).subscribe(response =>
      {
        this.members = response;
      });
  }

}
