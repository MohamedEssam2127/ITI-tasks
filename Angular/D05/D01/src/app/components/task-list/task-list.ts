import { Component, inject, computed, signal } from '@angular/core';
import { Card } from "../card/card";
import { TodoApi } from '../../services/todoApi';
import { TabsComponent } from '../tabs-component/tabs-component';
import { FilterType } from '../../types';

@Component({
  selector: 'app-task-list',
  imports: [Card, TabsComponent],
  templateUrl: './task-list.html',
  styleUrl: './task-list.css',
})
export class TaskList {
  apiService = inject(TodoApi);
  currentFilter = signal<FilterType>('all');

  filteredTodos = computed(() => {
    const filter = this.currentFilter();
    const todos = this.apiService.todos();

    if (filter === 'done') {
      return todos.filter(t => t.isSDone);
    } else if (filter === 'notDone') {
      return todos.filter(t => !t.isSDone);
    }
    return todos;
  });


ngOnInit() {
  const userData = localStorage.getItem('user');
  const email = userData ? JSON.parse(userData).email : null;

  this.apiService.todos.set([]);

  this.apiService.getAllTodos(email).subscribe((res) => {
    this.apiService.todos.set(res);
  });
}

  onFilterChange(filter: FilterType) {
    this.currentFilter.set(filter);
  }
}
