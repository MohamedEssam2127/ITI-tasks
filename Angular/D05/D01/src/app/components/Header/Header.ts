import { Component, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Flame } from '../flame/flame';
import { Router, RouterLink, RouterLinkActive } from "@angular/router";
import { UserApi } from '../../services/userApi';


@Component({
  selector: 'app-header',
  standalone: true,
  imports: [Flame, CommonModule,RouterLink, RouterLinkActive],
  templateUrl: './Header.html',
  styleUrl: './Header.css'
})
export class Header  {
  isFlameVisible:boolean=true;
  apiServer = inject(UserApi);
  islogin = this.apiServer.isLoggedIn;
  router = inject(Router)
  logout(){
    localStorage.clear();
    this.apiServer.isLoggedIn.set(false);
    this.router.navigate(['/signin'])
  }
}
