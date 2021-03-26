import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NgxGalleryAction, NgxGalleryAnimation, NgxGalleryImage, NgxGalleryOptions } from '@kolkov/ngx-gallery';
import { Member } from 'src/app/Models/member';
import { MemberService } from 'src/app/services/member.service';

@Component({
  selector: 'app-member-detail',
  templateUrl: './member-detail.component.html',
  styleUrls: ['./member-detail.component.css']
})
export class MemberDetailComponent implements OnInit {

  member: Member;
  galleryOptions: NgxGalleryOptions[];
  galleryImages: NgxGalleryImage[];

  constructor(private memberService: MemberService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.loadMember();

    this.galleryOptions = [
      {
        width: '500px',
        height: '500px',
        imagePercent: 100,
        thumbnailsColumns: 4,
        imageAnimation: NgxGalleryAnimation.Slide,
        preview: false
      }
    ];

  }

  getPhotos(): NgxGalleryImage[] {
    let imageUrls = [];
    for (var img of this.member.photos) {
      imageUrls.push({
        small: img.url,
        medium: img.url,
        big: img.url,
      })
    }
    return imageUrls;
  }

  loadMember() {
    this.memberService.getMember(this.route.snapshot.paramMap.get('username')).subscribe(member => {
      this.member = member;
      if (member) {
        this.galleryImages = this.getPhotos();
      }
    });
  }
}
