import { Component, EventEmitter, Output } from '@angular/core';
import {FormsModule} from '@angular/forms';
import { ToDo } from '../../types';
import { v4 as uuidv4 } from 'uuid';
@Component({
  selector: 'app-task-input',
  imports: [FormsModule],
  templateUrl: './task-input.html',
  styleUrl: './task-input.css',
})
export class TaskInput {
  data:ToDo[] =[]

  @Output() sendTodoToparent = new EventEmitter<ToDo>();

  inputObj:ToDo ={
    id: '',
    title:'',
    description:"" ,
    priority:"",
    date:"" ,
    tags:"",
    isSDone:false
  }
  addToArray(t: Event) {
    const newId = uuidv4().split('-')[0];
    this.sendTodoToparent.emit({ ...this.inputObj,id: newId});
  }
}


