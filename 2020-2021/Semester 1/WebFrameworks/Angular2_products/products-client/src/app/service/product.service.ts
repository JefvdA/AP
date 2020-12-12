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

  // Add a product
  addProduct(product: Product): void {
    let url = `${this.productsServiceURI}/add`
    // MUST SUBSCIBE TO EXECUTE POST
    this.http.post(url, product.getParams(), { headers: this.contentHeaders })
      .subscribe(data => { console.log(data); },
                 error => { console.error(error); });
  }

  // Search all products by name
  searchAllProducts(name: string): Observable<Product[]> {
    let url = `${this.productsServiceURI}/searchAll`;

    return this.http.post<Product[]>(url, `name=${name}`, { headers: this.contentHeaders });
  }

  // Search one product by name
  searchOneProduct(name: string): Observable<Product[]> {
    let url = `${this.productsServiceURI}/searchOne`;

    return this.http.post<Product[]>(url, `name=${name}`, { headers: this.contentHeaders });
  }

  // Delete a product
  deleteProduct(name: string): void {
    let url = `${this.productsServiceURI}/delete/${name}`;

    this.http.delete(url, { headers: this.contentHeaders })
      .subscribe(data => { console.log(data) },
                 error => { console.error(error) });
  }

  // Edit a product
  editProduct(product: Product): void {
    let url = `${this.productsServiceURI}/edit`;
    // MUST SUBSCRIBE TO EXECUTE POST
    this.http.post(url, product.getParams(), { headers: this.contentHeaders })
      .subscribe(data => { console.log(data) },
                 error => { console.error(error) });
  }
}
