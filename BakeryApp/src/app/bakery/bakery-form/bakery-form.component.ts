import { Bakery } from 'src/app/shared/bakery.model';
import {BakeryService} from 'src/app/shared/bakery.service';
import { Component, OnInit } from '@angular/core';
import {NgForm} from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-bakery-form',
  templateUrl: './bakery-form.component.html',
  styles: [
  ]
})
export class BakeryFormComponent implements OnInit {

  constructor(public service:BakeryService,
    private toastr:ToastrService){}

  ngOnInit(): void {
  }
  onSubmit(form:NgForm){
    if(this.service.formData.bakeryID == undefined)
      this.insertRecords(form)
    else
      this.updateRecords(form)

  }
  insertRecords(form:NgForm){
    this.service.postBakery().subscribe(
      res => {
    this.resetForm(form);
    this.service.refreshList();
    this.toastr.success('Submitted Successfully','Bakery Insert')
      },
      err => {console.log(err); }
    );
  }
  updateRecords(form:NgForm){
    this.service.putBakery().subscribe(
      res => {
    this.resetForm(form);
    this.service.refreshList();
    this.toastr.info('Submitted Successfully','Bakery Update')
      },
      err => {console.log(err); }
    );
  }
  resetForm(form:NgForm){
    form.form.reset();
    this.service.formData = new Bakery();
  }
}
