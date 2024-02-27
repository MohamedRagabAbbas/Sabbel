import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { AuthenticationService } from '../../Services/authentication.service';


@Component({
  selector: 'log-in',
  standalone: true,
  imports: [FormsModule,ReactiveFormsModule],
  templateUrl: './log-in.component.html',
  styleUrl: './log-in.component.css',
})
export class LogInComponent {
  formGroup:FormGroup = new FormGroup({});
  constructor(private router:Router, private formBuilder:FormBuilder,private authenticationService:AuthenticationService)
  {
    this.formGroup = this.formBuilder.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(6), Validators.pattern('^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])([a-zA-Z0-9]{8,})$')]]
    });
  }
  LogIn()
  {
    this.authenticationService.login(this.formGroup.get('email')?.value, this.formGroup.get('password')?.value);
  }
}
