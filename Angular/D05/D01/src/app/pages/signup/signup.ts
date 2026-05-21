import { Component, inject } from '@angular/core';
import {
  AbstractControl,
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  ValidationErrors,
  Validators,
} from '@angular/forms';
import { UserApi } from '../../services/userApi';
import { User } from '../../types';
import { Router } from '@angular/router';


 function matchPasswords(control: AbstractControl): ValidationErrors | null {
  const password = control.get('password')?.value;
  const confirmpassword = control.get('confirmpassword')?.value;
  return password === confirmpassword ? null : { missMatch: true };
}

@Component({
  selector: 'app-signup',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './signup.html',
  styleUrl: './signup.css'
})
export class Signup {
  showPassword = false;
  showConfirmPassword = false;
  apiServer = inject(UserApi);
  router = inject(Router);

 form = new FormGroup(
    {
      username: new FormControl('', [Validators.required]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.minLength(6)]),
      confirmpassword: new FormControl('', [Validators.required, Validators.minLength(6)]),
    },
    {
      validators: matchPasswords,
    },
  );
  handleSubmit() {
    if(this.form.controls.username.invalid||
       this.form.controls.password.invalid ||
      this.form.controls.email.invalid)
      return ;
    this.apiServer.addUser(this.form.value as User).subscribe(() => {
      this.router.navigate(['/home']);
      localStorage.setItem('user', JSON.stringify(this.form.value));
      this.apiServer.isLoggedIn.set(true);
    }, (error) => {
      console.error('Error adding user:', error);
    });
  }

}
