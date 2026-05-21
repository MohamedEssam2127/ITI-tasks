import { HttpClient } from '@angular/common/http';
import { Injectable , inject, signal} from '@angular/core';
import { ToDo, User } from '../types';

@Injectable({
  providedIn: 'root',
})
export class UserApi {
  baseUrl: string = "http://localhost:3000";
  http  = inject(HttpClient);
  isLoggedIn = signal<boolean>(localStorage.getItem('user') !== null);
  getUsers(){
    return this.http.get(`${this.baseUrl}/users`);
  }

  addUser(user:User){
   return this.http.post(`${this.baseUrl}/users`,user)
  }

isUserExist() {
  return this.http.get<User[]>(`${this.baseUrl}/users`);
}


}
