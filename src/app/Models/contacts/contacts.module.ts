import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class ContactsModule { 
  id:number = 0;
  phoneNumber:string = "";
  email:string = "";
  address:string = "";
}
