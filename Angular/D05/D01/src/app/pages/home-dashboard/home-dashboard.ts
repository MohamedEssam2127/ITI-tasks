import { Component } from '@angular/core';
import { Gallary } from "../../components/gallary/gallary";

@Component({
  selector: 'app-home-dashboard',
  standalone: true,
  imports: [Gallary],
  templateUrl: './home-dashboard.html',
  styleUrl: './home-dashboard.css'
})
export class HomeDashboard {
}
