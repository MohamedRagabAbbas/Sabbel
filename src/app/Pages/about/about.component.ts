import { Component } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { faCoffee,faHandshakeAngle, faMoneyBillWave, faDonate, faUser } from '@fortawesome/free-solid-svg-icons';
import { SabeelService } from '../../Services/sabeel.service';

@Component({
  selector: 'about',
  standalone: true,
  imports: [FontAwesomeModule],
  templateUrl: './about.component.html',
  styleUrl: './about.component.css',
})
export class AboutComponent {
  faCoffee = faCoffee;
  faHandshakeAngle = faHandshakeAngle;
  faMoneyBillWave = faMoneyBillWave;
  faDonate = faDonate;
  faUser = faUser;

  constructor(public sabeel:SabeelService) {
   }

}
