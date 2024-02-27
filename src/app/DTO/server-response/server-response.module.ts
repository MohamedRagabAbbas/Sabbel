import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class ServerResponseModule {
  message:string = "";
  isSuccess:boolean = false;
  data:any = null;
 }
