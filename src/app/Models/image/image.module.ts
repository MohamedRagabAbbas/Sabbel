import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EventModule } from '../event/event.module';
import { TeamMemberModule } from '../team-member/team-memebr.module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class ImageModule {
  id:number = 0;
  imageData:File = new File([""], "filename");
  imageDescription:string = "";
  eventId:number = 0;
  event:EventModule = new EventModule();
  teamMemberId:number = 0;
  teamMember:TeamMemberModule = new TeamMemberModule();
 }
