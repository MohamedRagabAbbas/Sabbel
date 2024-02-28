import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ImageModule } from '../image/image.module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class EventModule {
  id:number = 0;
  title:string = "";
  description:string = "";
  //image:ImageModule = new ImageModule();
  price:number = 0;
  date:Date = new Date();
  duration:string = "";
  isNonAucianAllowed:boolean = false;
 }
