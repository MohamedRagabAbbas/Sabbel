import { Routes } from '@angular/router';
import { LogInComponent } from './Pages/log-in/log-in.component';

export const routes: Routes = [
    {
        path: 'log-in',
        component: LogInComponent,
        pathMatch: 'full'
    }
];
