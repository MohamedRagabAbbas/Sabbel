import { Component } from '@angular/core';
import { SabeelService } from '../../Services/sabeel.service';

@Component({
  selector: 'mission-vision',
  standalone: true,
  imports: [],
  templateUrl: './mission-vision.component.html',
  styleUrl: './mission-vision.component.css'
})
export class MissionVisionComponent {
  constructor(public sabeel:SabeelService) {
  }

}
