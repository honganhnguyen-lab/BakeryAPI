import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from "@angular/common";
import { AppComponent } from './app.component';
import { BakeryComponent } from './bakery/bakery.component';
import { BakeryFormComponent } from './bakery/bakery-form/bakery-form.component';
import { ImageListComponent } from './image-list/image-list.component';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ToastrModule } from 'ngx-toastr';
import { BakeryFilterPipe } from './bakery/bakery-filter.pipe';

@NgModule({
  declarations: [
    AppComponent,
    BakeryFormComponent,
    BakeryComponent,
    ImageListComponent,
    BakeryFilterPipe
  ],
  imports: [
    BrowserModule,
    CommonModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
