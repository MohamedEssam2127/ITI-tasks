import { Injectable, signal } from '@angular/core';
import { ToastType } from '../types';

@Injectable({
  providedIn: 'root'
})
export class ToastService {
  toastType = signal<ToastType>('nothing');
  private timeoutId: any;

  showToast(type: ToastType) {
    this.toastType.set(type);

    if (this.timeoutId) {
      clearTimeout(this.timeoutId);
    }

    this.timeoutId = setTimeout(() => {
      this.toastType.set('nothing');
    }, 3000); 
  }
}
