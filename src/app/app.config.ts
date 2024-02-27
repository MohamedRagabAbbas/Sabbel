import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';
import { routes } from './app.routes';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { HttpClientModule } from '@angular/common/http';
import { AuthenticationService } from './Services/authentication.service';


export const appConfig: ApplicationConfig = {
  providers: [
    provideRouter(routes), 
    HttpClientModule, 
    AuthenticationService],
};
