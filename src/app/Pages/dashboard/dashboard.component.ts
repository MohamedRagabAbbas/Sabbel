import { Component } from '@angular/core';
import { RouterLinkActive, RouterOutlet } from '@angular/router';
import { Router, RouterEvent, NavigationEnd } from '@angular/router';


@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [RouterLinkActive,RouterOutlet],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css',
})
export class DashboardComponent {
  isAboutSabeelActive: boolean = false;
  isContactsActive: boolean = false;
  isTeamActive: boolean = false;
  isEventsActive: boolean = false;

  constructor(private router:Router) {
    this.router.navigate(["dashboard/about-sabeel"]);
    this.isAboutSabeelActive = true;


  }

  GoToAbout() {
    this.router.navigate(["dashboard/about-sabeel"]);
    this.isAboutSabeelActive = true;
    this.isContactsActive = false;
    this.isTeamActive = false;
    this.isEventsActive = false;
  }

  GoToContacts() {
    this.router.navigate(["dashboard/contacts"]);
    this.isContactsActive = true;
    this.isAboutSabeelActive = false;
    this.isTeamActive = false;
    this.isEventsActive = false;
  }
  GoToTeam()
  {
    this.router.navigate(["dashboard/Team"]);
    this.isTeamActive = true;
    this.isAboutSabeelActive = false;
    this.isContactsActive = false;
    this.isEventsActive = false;
  }
  GoToEvents()
  {
    this.router.navigate(["dashboard/Events"]);
    this.isEventsActive = true;
    this.isAboutSabeelActive = false;
    this.isContactsActive = false;
    this.isTeamActive = false;
  }

}
