import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';
import { routes } from './app.routes';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { HTTP_INTERCEPTORS, HttpClientModule, withInterceptors } from '@angular/common/http';
import { AuthenticationService } from './Services/authentication.service';
import { provideHttpClient } from '@angular/common/http';
import { authInterceptorInterceptor } from './Services/auth-interceptor.interceptor';
import { SabeelService } from './Services/sabeel.service';
export const appConfig: ApplicationConfig = {
  providers: [
    provideRouter(routes), 
    HttpClientModule, 
    AuthenticationService,
    SabeelService,
    provideHttpClient(withInterceptors([authInterceptorInterceptor]))
  ]
};
