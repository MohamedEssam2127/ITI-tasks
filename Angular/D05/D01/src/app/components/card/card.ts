import { Component, inject, Input } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ToDo } from '../../types';
import { TodoApi } from '../../services/todoApi';
import { ToastService } from '../../services/toastservice';

@Component({
  selector: 'app-card',
  imports: [FormsModule],
  templateUrl: './card.html',
  styleUrl: './card.css',
})
export class Card {
  @Input() toDo!: ToDo;

  apiService = inject(TodoApi);
  toastService = inject(ToastService);
  showActions = false;
  isEdited = false;
  editingTodo!: ToDo;

  deleteCard() {
    this.apiService.deleteTodo(this.toDo.id).subscribe(() => {
      this.apiService.todos.update(todos => todos.filter(t => t.id !== this.toDo.id));
      this.toastService.showToast('delete');
    });
  }

  toggleDone() {
    const updated = { ...this.toDo, isSDone: !this.toDo.isSDone };
    this.apiService.updateTodo(updated).subscribe(() => {
      this.apiService.todos.update(todos => todos.map(t => t.id === updated.id ? updated : t));
      if (updated.isSDone) {
        this.toastService.showToast('done');
      }
    });
  }

  enableEdit() {
    this.editingTodo = { ...this.toDo };
    this.isEdited = true;
  }

  cancelEdit() {
    this.isEdited = false;
  }

  saveEdit() {
    this.apiService.updateTodo(this.editingTodo).subscribe(() => {
      this.apiService.todos.update(todos => todos.map(t => t.id === this.editingTodo.id ? this.editingTodo : t));
      this.isEdited = false;
      this.toastService.showToast('update');
    });
  }
}
