import { Component, Input } from '@angular/core';
import { ToastType } from '../../types';

@Component({
  selector: 'app-toast',
  imports: [],
  templateUrl: './toast.html',
  styleUrl: './toast.css',
})
export class Toast {
  @Input()
toastType: ToastType = 'nothing';


}
