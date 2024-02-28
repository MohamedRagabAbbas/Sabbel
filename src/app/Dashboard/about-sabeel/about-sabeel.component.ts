import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { SabeelService } from '../../Services/sabeel.service';
import { AboutSabeelModule } from '../../Models/about-sabeel/about-sabeel.module';
import { ServerResponseModule } from '../../DTO/server-response/server-response.module';

@Component({
  selector: 'app-about-sabeel',
  standalone: true,
  imports: [FormsModule,ReactiveFormsModule],
  templateUrl: './about-sabeel.component.html',
  styleUrl: './about-sabeel.component.css'
})
export class AboutSabeelComponent {
  
  aboutSabeel: AboutSabeelModule = new AboutSabeelModule();
  constructor(private sabeel:SabeelService) { 
    this.sabeel.getAboutSabbelObservable().subscribe((data)=>{
      const response = data as ServerResponseModule;
      if(response.isSuccess==true)
      {
        this.aboutSabeel = response.data as AboutSabeelModule;
      }
      else{
        console.log(response.message);
      }
    });
    
  }
  Save()
  {
    this.sabeel.updateAboutSabeel(this.aboutSabeel);
  }

}
