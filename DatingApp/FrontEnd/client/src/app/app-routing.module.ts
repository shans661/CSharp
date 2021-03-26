import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './guards/auth.guard';
import { HomeComponent } from './home/home.component';
import { ListsComponent } from './members/lists/lists.component';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MessagesComponent } from './messages/messages.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { MemberEditComponent } from './members/member-edit/member-edit.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: '', runGuardsAndResolvers: 'always', canActivate: [AuthGuard],
    children: [
      { path: 'members', component: MemberListComponent, canActivate: [AuthGuard] },
      { path: 'members/:username', component: MemberDetailComponent },
      { path: 'member/edit', component: MemberEditComponent },
      { path: 'lists', component: ListsComponent },
      { path: 'messages', component: MessagesComponent },
      { path: '**', component: NotFoundComponent, pathMatch: 'full' }]
  },

  { path: 'not-found', component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
