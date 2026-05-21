import { Component } from '@angular/core';
import { Header } from './components/Header/Header';
import { Footer } from './components/Footer/Footer';

import { RouterOutlet } from "@angular/router";
import { Toast } from './components/toast/toast';

@Component({
  selector: 'app-root',
  imports: [Header, Footer, RouterOutlet, Toast],
  templateUrl: './app.html',
  styleUrl: './app.css'
})

export class App {



}
