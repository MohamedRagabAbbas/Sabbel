import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class AuthenticationResponseModule {
  id:number = 0;
  role:string = "";
  isAuthenticated:boolean = false;
  token:string = "";
  message:string = "";
 }
