import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Product } from './product';

@Injectable()
export class ProductService {

   private productsServiceURI: string = 'http://localhost:3000/products';
   private contentHeaders: HttpHeaders;

   constructor(private http: HttpClient) {
      this.contentHeaders = new HttpHeaders().set('Content-Type', 'application/x-www-form-urlencoded');
   }

   // Get all products
   getAllProducts(): Observable<Product[]> {
      let url = `${this.productsServiceURI}`;
      return this.http.get<Product[]>(url);
   }

   // Search a product based on the name
   searchProduct(name: string): Observable<Product[]> {
      let url = `${this.productsServiceURI}/search`;
      return this.http.post<Product[]>(url, `name=${name}`, { headers: this.contentHeaders });
   }

   // Search one product by name
   searchOneProduct(name: string): Observable<Product[]> {
      let url = `${this.productsServiceURI}/searchOne`

      return this.http.post<Product[]>(url, `name=${name}`,
                     { headers: this.contentHeaders })
   }

   // Edit a product
   editProduct(product: Product): void {
      let url = `${this.productsServiceURI}/edit`;
      // !!! subscribe is needed to execute POST
      this.http.post(url, product.getParams(),
                     { headers: this.contentHeaders })
                     .subscribe(data => { console.log(data) }, 
                                 error => { console.error(error) })
   }

   // Add a product
   addProduct(product: Product): void {
      let url = `${this.productsServiceURI}/add`;
      // !!! SUBSCRIBE IS NEEDED TO EXECUTE POST
      this.http.post(url, product.getParams(),
                     { headers: this.contentHeaders })
                     .subscribe(data => { console.log(data) },
                                error => { console.error(error) });
   }

   // Delete a product
   deleteProduct(name: string): void {
      let url = `${this.productsServiceURI}/delete/${name}`;
      // !!! subscribe is needed to execute DELETE
      this.http.delete(url,
                     { headers: this.contentHeaders })
                     .subscribe(data => { console.log(data) }, 
                                 error => { console.error(error) })
   }
}
