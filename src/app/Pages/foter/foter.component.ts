import { Component } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { faFacebook } from '@fortawesome/free-brands-svg-icons';
import { faTwitter } from '@fortawesome/free-brands-svg-icons';
import { faInstagram } from '@fortawesome/free-brands-svg-icons';
import { faYoutube } from '@fortawesome/free-brands-svg-icons';
import { faLinkedin } from '@fortawesome/free-brands-svg-icons';
import { SabeelService } from '../../Services/sabeel.service';




@Component({
  selector: 'foter',
  standalone: true,
  imports: [FontAwesomeModule],
  templateUrl: './foter.component.html',
  styleUrl: './foter.component.css'
})
export class FoterComponent {
  faFacebook = faFacebook;
  faTwitter = faTwitter;
  faInstagram = faInstagram;
  faYoutube = faYoutube;
  faLinkedin = faLinkedin;

  constructor(public sabeel:SabeelService) {
  }
}

