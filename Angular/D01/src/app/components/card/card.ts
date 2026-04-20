import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ToDo } from '../../types';

@Component({
  selector: 'app-card',
  imports: [FormsModule],
  templateUrl: './card.html',
  styleUrl: './card.css',
})
export class Card {
  @Input() toDo!: ToDo;
  @Output() update = new EventEmitter<ToDo>();
  @Output() delete = new EventEmitter<ToDo>();

  showActions = false;
  isEdited = false;

  toggleActions(event: MouseEvent) {
    const target = event.target as HTMLElement;
    if (target.closest('button') || this.isEdited) return;
    this.showActions = !this.showActions;
  }

  onDone() {
    this.toDo.isSDone = !this.toDo.isSDone;
  }

  onUpdate() {
    this.isEdited = true;
  }

  saveUpdate() {
    this.isEdited = false;
    this.showActions = false;
    this.update.emit(this.toDo);
  }

  cancelUpdate() {
    this.isEdited = false;
  }

  onDelete() {
    this.delete.emit(this.toDo);
  }
}
