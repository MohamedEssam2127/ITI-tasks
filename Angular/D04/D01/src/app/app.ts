import { Component } from '@angular/core';
import { Header } from './components/Header/Header';
import { Footer } from './components/Footer/Footer';
import { TaskList } from "./components/task-list/task-list";
import { TaskInput } from "./components/task-input/task-input";
import { Gallary } from "./components/gallary/gallary";
import { Toast } from "./components/toast/toast";
import { HomeDashboard } from './components/home-dashboard/home-dashboard';
import { AuthSignIn } from './components/auth-sign-in/auth-sign-in';
import { AuthSignUp } from './components/auth-sign-up/auth-sign-up';

@Component({
  selector: 'app-root',
  imports: [
    Header, 
    Footer, 
    TaskList, 
    TaskInput, 
    Gallary, 
    Toast, 
    HomeDashboard,
    AuthSignIn,
    AuthSignUp
  ],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
}
