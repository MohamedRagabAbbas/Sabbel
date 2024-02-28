import { Component } from '@angular/core';
import { SabeelService } from '../../Services/sabeel.service';
import { TeamMemberModule } from '../../Models/team-member/team-memebr.module';
import { ServerResponseModule } from '../../DTO/server-response/server-response.module';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-team',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './team.component.html',
  styleUrl: './team.component.css'
})
export class TeamComponent {
  
  team: Array<TeamMemberModule> = new Array<TeamMemberModule>();
  newTeamMember: TeamMemberModule = new TeamMemberModule();
  constructor(private sabeel:SabeelService) {
    this.sabeel.getTeamObservable().subscribe((data) => {
      const response = data as ServerResponseModule;
      if (response.isSuccess == true) {
        this.team = response.data as Array<TeamMemberModule>;
      } else {
        console.log(response.message);
      }
    });
  }
  addTeamMember()
  {
    const fileInputElement: HTMLInputElement = document.getElementById('filer_input2') as HTMLInputElement;
    if(fileInputElement.files && fileInputElement.files[0]){
      const image: Blob = fileInputElement.files[0];
      this.sabeel.addTeamMember(this.newTeamMember, image);
    };
  }

}
