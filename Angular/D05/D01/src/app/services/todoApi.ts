import { HttpClient } from '@angular/common/http';
import { Injectable , inject, signal} from '@angular/core';
import { ToDo } from '../types';
@Injectable({
  providedIn: 'root',
})
export class TodoApi {
  todos = signal<ToDo[]>([]);
  baseUrl: string = "http://localhost:3000/todos";
  http  = inject(HttpClient);

addTodo(todo :ToDo){
  return this.http.post<ToDo>(`${this.baseUrl}`,todo)
}
getAllTodos(email?: string) {
    const url = email ? `${this.baseUrl}?userEmail=${email}` : this.baseUrl;
    return this.http.get<ToDo[]>(url);
  }
deleteTodo(id: string) {
  return this.http.delete(`${this.baseUrl}/${id}`);
}
updateTodo(todo: ToDo) {
  return this.http.put<ToDo>(`${this.baseUrl}/${todo.id}`, todo);
}


}
