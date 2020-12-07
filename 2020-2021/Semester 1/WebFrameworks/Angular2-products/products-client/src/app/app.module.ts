import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent }  from './app.component';
import { ProductListComponent }  from './product-list/product-list.component';
import { ProductSearchComponent } from './product-search/product-search.component';
import { ProductAddComponent } from './product-add/product-add.component';
import { ProductDeleteComponent } from './product-delete/product-delete.component';
import { ProductEditComponent } from './product-edit/product-edit.component';
import { ProductService } from './service/product.service';

// define the routes
const appRoutes: Routes = [
  { path: '', component: ProductListComponent },
  { path: 'search', component: ProductSearchComponent },
  { path: 'add', component: ProductAddComponent },
  { path: 'delete', component: ProductDeleteComponent },
  { path: 'delete/:name', component: ProductDeleteComponent },
  { path: 'edit/:name', component: ProductEditComponent }
];

@NgModule({
  imports:      [ BrowserModule, 
                  HttpClientModule,
                  ReactiveFormsModule, 
                  RouterModule.forRoot(appRoutes) ],
  declarations: [ AppComponent, 
                  ProductListComponent,
                  ProductSearchComponent,
                  ProductAddComponent,
                  ProductDeleteComponent,
                  ProductEditComponent],
  providers:    [ ProductService ],
  bootstrap:    [ AppComponent ]
})

export class AppModule { }
