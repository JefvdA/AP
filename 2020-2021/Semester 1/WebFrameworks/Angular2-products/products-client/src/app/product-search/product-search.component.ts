import { Component } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Validators } from '@angular/forms';
import { Product } from '../service/product';
import { ProductService } from '../service/product.service';

@Component({
  selector: 'app-product-search',
  templateUrl: './product-search.component.html'
})

export class ProductSearchComponent {

  product = new Product('', '', '', '');
  productSearchForm = this.fb.group({
    name: ['', Validators.required]
  });

  constructor(private ps: ProductService,
              private fb: FormBuilder) { }

  onSubmit() {
    this.ps.searchProduct(this.productSearchForm.value.name)
      .subscribe(data => { this.product = data; },
                 error => { console.error(error); });
  }

}
