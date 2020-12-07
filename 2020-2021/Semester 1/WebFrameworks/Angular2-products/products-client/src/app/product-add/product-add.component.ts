import { Component } from '@angular/core';
import { Product } from '../service/product';
import { ProductService } from '../service/product.service';
import { FormBuilder } from '@angular/forms';
import { Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html'
})

export class ProductAddComponent {

  product = this.fb.group({
    name: ['', Validators.required],
    brand: ['', Validators.required],
    description: ['', Validators.required],
    price: ['', Validators.required]
  })

  constructor(private ps: ProductService,
              private fb: FormBuilder,
              private router: Router) { }

  onSubmit() {
    this.ps.addProduct(new Product(
      this.product.value.name,
      this.product.value.brand,
      this.product.value.description,
      this.product.value.price
    ));

    this.router.navigate(['']);
  }

}
