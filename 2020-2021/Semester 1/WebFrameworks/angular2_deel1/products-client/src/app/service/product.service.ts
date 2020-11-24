import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Product } from './product';

@Injectable()
export class ProductService {

    private productServiceURI: string = 'http://localhost:3000/products';
    private contentHeaders: HttpHeaders;

    constructor(private http: HttpClient){
        this.contentHeaders = new HttpHeaders().set('Content-Type', 'application/x-www-from-urlencoded');
    }

    //Get all products
    getAllProducts(): Observable<Product[]> {
        let url = '${this.productServiceURI}';
        return this.http.get<Product[]>(url);
    }

    //Search a product based on the name
    searchProduct(name: string): Observable<Product> {
        let url = '${this.productServiceURI}/search';
        return this.http.post<Product>(url, 'name=${name}', { headers: this.contentHeaders });
    }
}
