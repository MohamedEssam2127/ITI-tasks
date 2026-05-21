import { Component, Input ,Output ,EventEmitter} from '@angular/core';

@Component({
  selector: 'app-flame',
  imports: [],
  templateUrl: './flame.html',
  styleUrl: './flame.css',
})
export class Flame {
  @Input() streak: number = 0;
   @Output() streakCompleted = new EventEmitter<void>();

    ngOnDestroy() {
    this.streakCompleted.emit();
    console.log('%c flame Destroy ', 'color:red');
  }
}
