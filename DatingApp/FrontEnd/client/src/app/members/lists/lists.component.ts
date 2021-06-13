import { Component, OnInit } from '@angular/core';
import { Member } from 'src/app/Models/member';
import { Pagination } from 'src/app/Models/pagination';
import { UserParams } from 'src/app/Models/userParams';
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
  pagination: Pagination;
  userParams: UserParams;
  predicate: string = "liked";

  constructor(private memberService: MemberService) { }

  ngOnInit(): void {
    this.loadLikes(this.liked);
  }

  loadLikes(predicate: string){
    this.predicate = predicate;
    this.memberService.setUserparams(this.userParams);
    this.memberService.getLikes(predicate, this.userParams).subscribe(response =>
      {
        this.members = response.result;
        this.pagination = response.pagination;
      });
  }

  pageChanges(event: any){
    this.userParams.pageNumber = event.page;
    this.loadLikes(this.predicate);
  }

}
