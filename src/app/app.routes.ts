import { Routes } from '@angular/router';
import { LogInComponent } from './Pages/log-in/log-in.component';
import { DashboardComponent } from './Pages/dashboard/dashboard.component';
import { AboutSabeelComponent } from './Dashboard/about-sabeel/about-sabeel.component';
import { TeamComponent } from './Pages/team/team.component';
import { EventsComponent } from './Pages/events/events.component';
import { ContactsComponent } from './Dashboard/contacts/contacts.component';

export const routes: Routes = [
    {path: 'log-in',component: LogInComponent,},
    // add dashboard route here and their children routes
    {path: 'dashboard',component: DashboardComponent, children: [
        {path: 'about-sabeel',component: AboutSabeelComponent},
        {path: 'contacts',component: ContactsComponent,},
        {path: 'Team',component: TeamComponent,},
        {path: 'Events',component: EventsComponent,},
    ]},





];
