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
  constructor(private router:Router) {

  }

  GoToAbout() {
    this.router.navigate(["dashboard/about-sabeel"]);
  }

  GoToContacts() {
    this.router.navigate(["dashboard/contacts"]);
  }
  GoToTeam()
  {
    this.router.navigate(["dashboard/Team"]);
  }
  GoToEvents()
  {
    this.router.navigate(["dashboard/Events"]);
  }

}
