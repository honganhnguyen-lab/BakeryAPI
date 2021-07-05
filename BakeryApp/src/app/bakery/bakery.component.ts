import { BakeryService } from '../shared/bakery.service';
import {Bakery } from '../shared/bakery.model';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';



@Component({
  selector: 'app-bakery',
  templateUrl: './bakery.component.html',
  styles: [
  ]
})
export class BakeryComponent implements OnInit {
  constructor(public service: BakeryService,
    private toastr:ToastrService){}
    public bakeryName:string;
  ngOnInit(): void {
    this.service.refreshList();
  }
  populateForm(selectedRecord: Bakery) {
    this.service.formData = Object.assign({}, selectedRecord);
  }

  onDelete(id:number){
    if(confirm('Are you sure to delete this record ?')){
    this.service.deleteBakery(id)
    .subscribe(
      res =>{
        this.service.refreshList();
        this.toastr.error("Delete Succesfully",'Bakery Register');
      },
      err =>{console.log(err)}
    )
  }
}


}
