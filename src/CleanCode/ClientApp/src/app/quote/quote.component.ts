import { Component } from '@angular/core';

@Component({
  selector: 'app-quote-component',
    templateUrl: './quote.component.html'
})
export class QuoteComponent {
  public currentCount = 0;

  public quote() {
    this.currentCount++;
  }
}
