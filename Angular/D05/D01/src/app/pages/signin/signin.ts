import { Component ,inject } from '@angular/core';
import { FormsModule, NgForm, NgModel } from '@angular/forms';
import { Router } from '@angular/router';
import { UserApi } from '../../services/userApi';
@Component({
  selector: 'app-signin',
  standalone: true,
  imports: [FormsModule  ],
  templateUrl: './signin.html',
  styleUrl: './signin.css'
})
export class Signin {
  showPassword = false;
  router = inject(Router);
  apiServer = inject(UserApi);
  authFailed = this.apiServer.isLoggedIn;
  onSubmitClicked:boolean = false;


onSubmit(form: NgForm, email: NgModel, password: NgModel) {
  this.onSubmitClicked = true;

  this.apiServer.isUserExist()
    .subscribe(users => {
      const user = users.find(
        u => u.email === email.value && u.password === password.value
      );

      if (user) {
        localStorage.setItem('user', JSON.stringify(user));
        this.apiServer.isLoggedIn.set(true);

        this.router.navigate(['/home']);
      } else {
        this.apiServer.isLoggedIn.set(false);
      }
    });
}
}
