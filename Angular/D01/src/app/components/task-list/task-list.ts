import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Card } from "../card/card";
import { ToDo } from '../../types';

@Component({
  selector: 'app-task-list',
  imports: [Card],
  templateUrl: './task-list.html',
  styleUrl: './task-list.css',
})
export class TaskList {
  @Input()
  toDos:ToDo[] = [];

  @Output()update = new EventEmitter<ToDo>();

  @Output()delete = new EventEmitter<ToDo>();

  deleteToDo(toDo: ToDo) {
    this.delete.emit(toDo);
  }
  updateToDo(toDo: ToDo) {
    this.update.emit(toDo);
  }
}
