import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent }  from './app.component';
import { ProductListComponent }  from './product-list/product-list.component';
import { ProductSearchComponent } from './product-search/product-search.component';
import { ProductService } from './service/product.service';

// define the routes
const appRoutes: Routes = [
  { path: '', component: ProductListComponent },
  { path: 'search', component: ProductSearchComponent }
];

@NgModule({
  imports:      [ BrowserModule, 
                  HttpClientModule,
                  ReactiveFormsModule, 
                  RouterModule.forRoot(appRoutes) ],
  declarations: [ AppComponent, 
                  ProductListComponent,
                  ProductSearchComponent],
  providers:    [ ProductService ],
  bootstrap:    [ AppComponent ]
})

export class AppModule { }
