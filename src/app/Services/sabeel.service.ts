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
  getAboutSabeel(){
    return this.httpClint.get(`${url}Details/GetAll`);
  }
  getContacts(){
    return this.httpClint.get("http://localhost:8080/contacts");
  }
  getTeam(){
    return this.httpClint.get("http://localhost:8080/team");
  }
  getEvents(){
    return this.httpClint.get("http://localhost:8080/events");
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
