import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AboutSabeelModule } from '../Models/about-sabeel/about-sabeel.module';
import { ContactsModule } from '../Models/contacts/contacts.module';
import { TeamMemberModule } from '../Models/team-member/team-memebr.module';
import { EventModule } from '../Models/event/event.module';
import { OnInit } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SabeelService implements  OnInit{

  url:string = "https://localhost:7089/api/";
  aboutSabeel:AboutSabeelModule = new AboutSabeelModule();
  contacts:ContactsModule = new ContactsModule();
  team:TeamMemberModule[] = new Array<TeamMemberModule>();
  events: EventModule[] = new Array<EventModule>(); 

  constructor(private httpClint:HttpClient) { }
  ngOnInit(){
    
  }
  // get methods
  getAboutSabeel(){
     this.httpClint.get(`${this.url}Details/GetById/1`);
  }
  getContacts(){
     this.httpClint.get(`${this.url}Contacts/GetById/1`);
  }
  getTeam(){
     this.httpClint.get(`${this.url}Teem/GetAll/1`);
  }
  getEvents(){
     this.httpClint.get(`${this.url}Details/GetById/1`);
  }


  addEvent(event:EventModule){
    return this.httpClint.post("http://localhost:8080/events",event);
  }
  deleteEvent(id:number){
    return this.httpClint.delete("http://localhost:8080/events/"+id);
  }
  updateEvent(event:EventModule){
    return this.httpClint.put("http://localhost:8080/events",event);
  }
  addTeamMember(member:TeamMemberModule){
    return this.httpClint.post("http://localhost:8080/team",member);
  }
  deleteTeamMember(id:number){
    return this.httpClint.delete("http://localhost:8080/team/"+id);
  }
  updateTeamMember(member:TeamMemberModule){
    return this.httpClint.put("http://localhost:8080/team",member);
  }
  updateAboutSabeel(about:AboutSabeelModule){
    return this.httpClint.put("http://localhost:8080/aboutSabeel",about);
  }


  

}
