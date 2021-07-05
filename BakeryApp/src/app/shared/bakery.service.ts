import { Bakery } from './bakery.model';
import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class BakeryService {

  formData: Bakery = new Bakery();
  lists : Bakery[];
  readonly baseURL='http://localhost:21842/api/Bakery';
  filter: any;

  constructor(private http: HttpClient) { }

  postBakery(){
    return this.http.post(this.baseURL,this.formData)

    }
  putBakery(){
    return this.http.put(`${this.baseURL}/${this.formData.bakeryID}`,this.formData)

    }
  deleteBakery(id:number){
    return this.http.delete(`${this.baseURL}/${id}`)
  }
  
  refreshList(){
    this.http.get(this.baseURL)
    .toPromise().then(res => this.lists = res as Bakery[]);
  }
}
