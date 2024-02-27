import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';


@Component({
  selector: 'log-in',
  standalone: true,
  imports: [FormsModule,ReactiveFormsModule],
  templateUrl: './log-in.component.html',
  styleUrl: './log-in.component.css'
})
export class LogInComponent {
  formGroup:FormGroup = new FormGroup({});
  constructor(private router:Router, private formBuilder:FormBuilder)
  {
    this.formGroup = this.formBuilder.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(6), Validators.pattern('^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])([a-zA-Z0-9]{8,})$')]]
    });
  }
  LogIn()
  {
    console.log("Log In");
    console.log(this.formGroup.value);
    console.log(this.formGroup.controls['email'].value);
    console.log(this.formGroup.controls['password'].value);
    //this.router.navigate(['/dashboard']);
  }
}
