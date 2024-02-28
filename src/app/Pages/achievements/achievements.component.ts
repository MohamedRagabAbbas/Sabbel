import { Component } from '@angular/core';
import { SabeelService } from '../../Services/sabeel.service';

@Component({
  selector: 'achievements',
  standalone: true,
  imports: [],
  templateUrl: './achievements.component.html',
  styleUrl: './achievements.component.css'
})
export class AchievementsComponent {
  constructor(public sabeel:SabeelService) {
  }

}
