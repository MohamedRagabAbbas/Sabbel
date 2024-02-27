import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  private url = "https://localhost:7089/";
  constructor(private http:HttpClient) 
  {

  }
  login()
  {
    this.http.get
  }
}
