import { Menu1Service } from './services/menu1.service';
import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, FormsModule, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'ldrp';
  name = '';

  isNameVisible = false;

  ldrpStudents = ['Shivam', 'Rahul', 'Prachi'];

  constructor(private menu1Service: Menu1Service) {}

  onclick() {
    console.log('inComponent')
    this.menu1Service.onsubmit(this.name);
  }
}
