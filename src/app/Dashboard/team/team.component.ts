import { Component } from '@angular/core';
import { SabeelService } from '../../Services/sabeel.service';

@Component({
  selector: 'app-team',
  standalone: true,
  imports: [],
  templateUrl: './team.component.html',
  styleUrl: './team.component.css'
})
export class TeamComponent {
  
  constructor(sabeel:SabeelService) {

  }

}
