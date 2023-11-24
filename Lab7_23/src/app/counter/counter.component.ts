import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatButtonModule} from "@angular/material/button";

@Component({
  selector: 'app-counter',
  standalone: true,
    imports: [CommonModule, MatButtonModule],
  templateUrl: './counter.component.html',
  styleUrl: './counter.component.scss'
})
export class CounterComponent {
  constructor() { }

  counter: number = 0;

  increment() {
    this.counter++;
  }

  decrement() {
    this.counter--;
  }
}
