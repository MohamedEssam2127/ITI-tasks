import { Component, signal } from '@angular/core';
import { Header } from './components/Header/Header';
import { Footer } from './components/Footer/Footer';
import { TaskList } from "./components/task-list/task-list";
import { TaskInput } from "./components/task-input/task-input";
import { Gallary } from "./components/gallary/gallary";
import { FilterType, ToastType, ToDo } from './types';
import { TabsComponent } from './components/tabs-component/tabs-component';
import { Toast } from "./components/toast/toast";

@Component({
  selector: 'app-root',
  imports: [Header, Footer, TaskList, TaskInput, Gallary, TabsComponent, Toast],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {

  toDos:ToDo[] = [ {id:'1', title:'Task 1', description:'Description for Task 1', priority:'high', date:'2024-06-01', tags:'work, urgent', isSDone:false},
  {id:'2', title:'Task 2', description:'Description for Task 2', priority:'medium', date:'2024-06-02', tags:'home, low', isSDone:true},
  {id:'3', title:'Task 3', description:'Description for Task 3', priority:'low', date:'2024-06-03', tags:'leisure, medium', isSDone:false}];
  filteredToDos :ToDo[]= this.toDos;

  currentFilter: FilterType = 'all';

  tostType: ToastType = 'nothing';
  flameStreak = 0

  addToToDos(todo: ToDo) {
    this.toDos.push(todo);
    this.tostType = 'success';
     setTimeout(() => {
    this.tostType = 'nothing';
  }, 1000);
  }

  setFilter(filter: FilterType) {
  this.currentFilter = filter;

  if(this.currentFilter === 'done') {
    this.filteredToDos = this.toDos.filter(todo => todo.isSDone);
  } else if(this.currentFilter === 'notDone') {
    this.filteredToDos = this.toDos.filter(todo => !todo.isSDone);
  }else{
    this.filteredToDos = this.toDos;
  }
  // console.log(this.filteredToDos);
}

updateToDo(toDo: ToDo) {
this.tostType = 'update';
setTimeout(() => {
  this.tostType = 'nothing';}, 1000);

  console.log(`update${toDo.id}`);

}

deleteToDo(toDo: ToDo) {

  this.tostType = 'delete';
  setTimeout(() => {
    this.tostType = 'nothing';
  }, 1000);
  this.toDos = this.toDos.filter(t => t.id !== toDo.id);
  this.setFilter(this.currentFilter);
}

makeToDoDone(todo:ToDo){
  this.toDos = this.toDos.map(t =>
    t.id === todo.id ? { ...t, isSDone: !t.isSDone } : t
  );
  if(!todo.isSDone)
  this.flameStreak ++;
  this.setFilter(this.currentFilter);
}
onStreakCompleted() {
  this.flameStreak = 0;
}

}
