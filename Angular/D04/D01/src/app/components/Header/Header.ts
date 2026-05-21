import { Component } from '@angular/core';
import { Flame } from '../flame/flame';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [Flame],
  templateUrl: './Header.html',
  styleUrl: './Header.css'
})
export class Header  {
}
