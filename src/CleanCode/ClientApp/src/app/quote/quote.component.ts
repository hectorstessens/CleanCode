import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
    selector: 'app-quote-component',
    templateUrl: './quote.component.html'
})


export class QuoteComponent {

    public message: string;
    public quoteData: QuoteData;
    public http: HttpClient;
    public baseUrl: string;
    public quoteForm: FormGroup;
    constructor( http: HttpClient,
                  @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl;
        this.http = http;
        this.quoteForm = new FormGroup({
            branch: new FormControl(),
            insuredValue: new FormControl()
        });

    }
    public quote() {
        const formValue = this.quoteForm.value;
        this.http.get<QuoteData>(this.baseUrl + `api/Quote?branch=${formValue.branch}&insuredValue=${formValue.insuredValue}`).subscribe(result => {
            this.quoteData = result;
            this.message = "Cotización Realizada";
        }, error => {
                this.message = error.error;
                this.quoteData.coverages = [];
        });
    }

}



class QuoteData {
    branch: string;
    insuredValue: string;
    price: string;
    sumaAsegurada: string;
    precio: number;
    coverages: Coverage[] = [];
}

class Coverage {
    id: string;
    coverageName: number;
    value: number;
}
