import { Component, OnInit, OnDestroy } from '@angular/core';

@Component({
  selector: 'app-gallary',
  imports: [],
  templateUrl: './gallary.html',
  styleUrl: './gallary.css',
})
export class Gallary  {
  images: string[] = ['1.jpeg', '2.png', '3.jpeg', '4.png'];
  active: number = 0;
  intervalId: any;

  // ngOnInit() {
  //   // this.startInterval();
  // }

  // ngOnDestroy() {
  //   // if (this.intervalId) {
  //   //   clearInterval(this.intervalId);
  //   // }
  // }

  // startInterval() {
  //   this.intervalId = setInterval(() => {
  //     this.right();
  //   }, 2000);
  // }

  right() {
    if (this.active == this.images.length - 1) {
      this.active = 0;
    } else {
      ++this.active;
    }
  }

  left() {
    if (this.active == 0) {
      this.active = this.images.length - 1;
    } else {
      --this.active;
    }
  }

  goToImage(index: number) {
    this.active = index;
  }
}
