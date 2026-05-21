import { Component, inject, ChangeDetectorRef } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ToDo } from '../../types';
import { v4 as uuidv4 } from 'uuid';
import { TodoApi } from '../../services/todoApi';
import { ToastService } from '../../services/toastservice';

@Component({
  selector: 'app-task-input',
  imports: [FormsModule],
  templateUrl: './task-input.html',
  styleUrl: './task-input.css',
})
export class TaskInput {
  private apiService = inject(TodoApi);
  private toastService = inject(ToastService);
  private cdr = inject(ChangeDetectorRef);

  isSubmitted = false;
  inputObj: ToDo = this.resetForm();

  private resetForm(): ToDo {
    return {
      id: '',
      title: '',
      description: '',
      priority: '',
      date: '',
      tags: '',
      isSDone: false,
      userEmail: ''
    };
  }

  addToArray() {
    const { title, description, priority, date, tags } = this.inputObj;
    const isEmpty = !title || !description || !priority || !date || !tags;

    if (isEmpty) {
      this.isSubmitted = true;
      return;
    }

    const userData = localStorage.getItem('user');
    if (userData) {
      const user = JSON.parse(userData);
      this.inputObj.userEmail = user.email || '';
    }

    this.inputObj.id = uuidv4().split('-')[0];

    this.apiService.addTodo(this.inputObj).subscribe({
      next: (res) => {
        this.apiService.todos.update(todos => [...todos, res]);
        this.toastService.showToast('success');

        setTimeout(() => {
          this.inputObj = this.resetForm();
          this.isSubmitted = false;
          this.cdr.detectChanges();
        });
      },
      error: (err) => {
        console.error(err);
      }
    });
  }
}
