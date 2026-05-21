import { Component, Input, OnInit, OnDestroy, OnChanges, SimpleChanges, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Flame } from '../flame/flame';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [Flame, CommonModule],
  templateUrl: './Header.html',
  styleUrl: './Header.css'
})
export class Header  {
  @Input() counter: number = 0;
  @Output() streakCompleted = new EventEmitter<void>();

  timer = '00:00';
  isFlameVisible = false;
  private secondsRemaining = 3;
  private intervalId: any;

  ngOnInit() {
    console.log('%c Header Init ', 'color:green');
  }

  ngOnChanges(changes: SimpleChanges) {
    if ( !changes['counter'].firstChange) {
      if (changes['counter'].currentValue > 0) {
        this.resetAndStartTimer();
      }
    }
  }

  private resetAndStartTimer() {
    this.isFlameVisible = true;
    this.secondsRemaining = 3;
    this.timer = '00:03';

    if (this.intervalId) {
      clearInterval(this.intervalId);
    }

    this.startCountdown();
  }

  private startCountdown() {
    this.intervalId = setInterval(() => {
      if (this.secondsRemaining > 0) {
        this.secondsRemaining--;
        this.formatTime();
      } else {
        this.completeCycle();
      }
    }, 1000);
  }

  private formatTime() {
    const sDisplay = this.secondsRemaining.toString().padStart(2, '0');
    this.timer = `00:${sDisplay}`;
  }

   completeCycle() {
    clearInterval(this.intervalId);
    this.isFlameVisible = false;
    this.timer = '00:00';
    this.streakCompleted.emit();
  }

}
