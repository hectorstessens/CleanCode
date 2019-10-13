import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
    public planList: Plan[];
  public quoteData: QuoteData
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
      http.get<Plan[]>(baseUrl + 'api/Quote/GetPlans').subscribe(result => {
          this.planList = result;
    }, error => console.error(error));

      http.get<QuoteData>(baseUrl + 'api/Quote').subscribe(result => {
      this.quoteData = result;
    }, error => console.error(error));

  }
}

interface Plan {
  name: string;
  franchise: number;
  price: number;
  coverage: string;
}

interface QuoteData
{
  Coverages: Coverage[];
  Price: number;
}

interface Coverage {
  Id: string;
  CoverageName: number;
  Value: number;
}

