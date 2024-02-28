import { Component } from '@angular/core';
import { SabeelService } from '../../Services/sabeel.service';

@Component({
  selector: 'events',
  standalone: true,
  imports: [],
  templateUrl: './events.component.html',
  styleUrl: './events.component.css'
})
export class EventsComponent {
  constructor(public sabeel:SabeelService) {
  }


}
