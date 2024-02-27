import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class AuthenticationResponseModule {
  Id:number = 0;
  Role:string = "";
  IsAuthenticated:boolean = false;
  Token:string = "";
  Message:string = "";
 }
