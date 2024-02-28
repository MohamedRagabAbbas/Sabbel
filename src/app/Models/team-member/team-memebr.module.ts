import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ImageModule } from '../image/image.module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class TeamMemberModule {
  id:number = 0;
  name:string = "";
  position:string = "";
  description:string = "";
  image:ImageModule = new ImageModule();
 }
