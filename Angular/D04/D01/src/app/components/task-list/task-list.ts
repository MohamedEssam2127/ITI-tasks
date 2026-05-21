import { Component } from '@angular/core';
import { Card } from "../card/card";
import { TabsComponent } from '../tabs-component/tabs-component';

@Component({
  selector: 'app-task-list',
  standalone: true,
  imports: [Card, TabsComponent],
  templateUrl: './task-list.html',
  styleUrl: './task-list.css',
})
export class TaskList {
}
