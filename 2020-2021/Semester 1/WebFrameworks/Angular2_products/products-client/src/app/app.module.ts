import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { ProductListComponent } from './product-list/product-list.component';
import { ProductService } from './service/product.service';
import { ProductSearchComponent } from './product-search/product-search.component';
import { ProductAddComponent } from './product-add/product-add.component';
import { ProductDeleteComponent } from './product-delete/product-delete.component';
import { ProductEditComponent } from './product-edit/product-edit.component';
import { LoginComponent } from './login/login.component';
import { AuthenticationService } from './service/authentication.service';
import { AuthGuard } from './service/auth.guard';

// define the routes
const appRoutes: Routes = [
  { path: '', component: ProductListComponent },
  { path: 'search', component: ProductSearchComponent },
  { path: 'add', component: ProductAddComponent, canActivate: [AuthGuard] },
  { path: 'delete', component: ProductDeleteComponent, canActivate: [AuthGuard] },
  { path: 'delete/:name', component: ProductDeleteComponent, canActivate: [AuthGuard] },
  { path: 'edit/:name', component: ProductEditComponent, canActivate: [AuthGuard] },
  { path: 'login', component: LoginComponent }
]

@NgModule({
  declarations: [
    AppComponent,
    ProductListComponent,
    ProductSearchComponent,
    ProductAddComponent,
    ProductDeleteComponent,
    ProductEditComponent,
    LoginComponent ],
  imports: [
    BrowserModule,
    HttpClientModule,
    ReactiveFormsModule,
    RouterModule.forRoot(appRoutes) ],
  providers: [ProductService,
              AuthenticationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
