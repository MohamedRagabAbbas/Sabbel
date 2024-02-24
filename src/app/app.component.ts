import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLinkActive, RouterOutlet } from '@angular/router';
import { NavbarComponent } from './Pages/navbar/navbar.component';
import { HomeComponent } from './Pages/home/home.component';
import { AboutComponent } from './Pages/about/about.component';
import { MissionVisionComponent} from './Pages/mission-vision/mission-vision.component';
import { EventsComponent} from './Pages/events/events.component';
import { AchievementsComponent } from './Pages/achievements/achievements.component';
import { TeamComponent } from './Pages/team/team.component';
import { FoterComponent } from './Pages/foter/foter.component';
import { LogInComponent } from './Pages/log-in/log-in.component';
import { Router, RouterEvent, NavigationEnd } from '@angular/router';



@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    CommonModule, 
    RouterOutlet,
    NavbarComponent,
    HomeComponent,
    AboutComponent,
    MissionVisionComponent,
    EventsComponent,
    AchievementsComponent,
    TeamComponent,
    FoterComponent,
    LogInComponent
  ],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Sabeel';
  isLogInPageActive: boolean = false;

  constructor(private router: Router) {
    this.router.events.subscribe((event: any) => {
      if (event instanceof NavigationEnd) {
        this.isLogInPageActive = (event.url === '/log-in' || event.url === '/dashboard');
      }
    });
  }
}
