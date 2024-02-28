import { Component } from '@angular/core';
import { SabeelService } from '../../Services/sabeel.service';
import { EventModule } from '../../Models/event/event.module';
import { ServerResponseModule } from '../../DTO/server-response/server-response.module';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-events',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './events.component.html',
  styleUrl: './events.component.css'
})
export class EventsComponent {
  file: File= new File([],'');
  events: Array<EventModule> = new Array<EventModule>();
  newEvent: EventModule = new EventModule();
  constructor(private sabeel: SabeelService) {
    this.sabeel.getEventsObservable().subscribe((data) => {
      const response = data as ServerResponseModule;
      if (response.isSuccess == true) {
        this.events = response.data as Array<EventModule>;
      } else {
        console.log(response.message);
      }
    });
  }
  addEvent(){
    const fileInputElement: HTMLInputElement = document.getElementById('filer_input2') as HTMLInputElement;
    if(fileInputElement.files && fileInputElement.files[0]){
      const image: Blob = fileInputElement.files[0];
      this.sabeel.addEvent(this.newEvent,this.file, image);
    }

  }
}
