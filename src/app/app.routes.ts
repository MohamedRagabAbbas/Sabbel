import { Routes } from '@angular/router';
import { LogInComponent } from './Pages/log-in/log-in.component';
import { DashboardComponent } from './Pages/dashboard/dashboard.component';

export const routes: Routes = [
    {
        path: 'log-in',
        component: LogInComponent,
    },
    {
        path: 'dashboard',
        component:DashboardComponent,
    }
];
