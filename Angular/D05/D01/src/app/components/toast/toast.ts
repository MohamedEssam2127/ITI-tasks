import { Component, inject } from '@angular/core';
import { ToastService } from '../../services/toastservice';

@Component({
  selector: 'app-toast',
  imports: [],
  templateUrl: './toast.html',
  styleUrl: './toast.css',
})
export class Toast {
  toastService = inject(ToastService);
}
