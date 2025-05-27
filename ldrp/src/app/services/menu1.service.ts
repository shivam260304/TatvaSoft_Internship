import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class Menu1Service {

  constructor() { }

  onsubmit(name: string) {
    console.log("Submiteed")
    console.log(name)
  }
}
