import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-quote-component',
    templateUrl: './quote.component.html'
})
export class QuoteComponent {

    public quoteData: QuoteData;
    public http: HttpClient;
    public baseUrl: string;
    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl;
        this.http = http;
    }
    public quote() {
        this.http.get<QuoteData>(this.baseUrl + 'api/Quote').subscribe(result => {
            this.quoteData = result;
        }, error => console.error(error));
    }

}

interface QuoteData {
    branch: string;
    insuredValue: string;
    price: string;
    sumaAsegurada: string;
    precio: number;
}
