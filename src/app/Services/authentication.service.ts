import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AuthenticationResponseModule } from '../DTO/server-response/authentication-response.module';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  private url = "https://localhost:7089/api/Authentication/";
  public AuthenticationResponse:AuthenticationResponseModule = new AuthenticationResponseModule();

  constructor(private http:HttpClient) 
  {

  }
 login(email:string, password:string)
  {
    if(email === null || password === null)
    {
      this.AuthenticationResponse.isAuthenticated = false;
      this.AuthenticationResponse.message = "Email or password is null";
      return;
    }
    this.http.get(this.url + `login/${email}/${password}`).subscribe((data:any) => {
      this.AuthenticationResponse=  data as AuthenticationResponseModule;
      if(this.AuthenticationResponse.isAuthenticated === true)
      {
        console.log("Token: " + this.AuthenticationResponse.token);
        localStorage.setItem("token", this.AuthenticationResponse.token);
      }
    });
  }
  logout()
  {
    localStorage.removeItem("token");
  }
}
