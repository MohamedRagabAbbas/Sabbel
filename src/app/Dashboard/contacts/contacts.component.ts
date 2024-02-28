import { Component } from '@angular/core';
import { ContactsModule } from '../../Models/contacts/contacts.module';
import { SabeelService } from '../../Services/sabeel.service';
import { ServerResponseModule } from '../../DTO/server-response/server-response.module';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-contacts',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './contacts.component.html',
  styleUrl: './contacts.component.css'
})
export class ContactsComponent {
  contacts:ContactsModule = new ContactsModule();
  constructor(private sabeel:SabeelService) { 
    this.sabeel.getContactsObservable().subscribe((data)=>{
      const response = data as ServerResponseModule;
      if(response.isSuccess==true)
      {
        this.contacts = response.data as ContactsModule;
      }
      else{
        console.log(response.message);
      }
    });
  }
  Save()
  {
    this.sabeel.updateContact(this.contacts);
  }
}
