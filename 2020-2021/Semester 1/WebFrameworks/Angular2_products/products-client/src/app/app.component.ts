import { Component } from '@angular/core';
import { AuthenticationService } from './service/authentication.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})

export class AppComponent {
  
  constructor(private as: AuthenticationService, private router: Router) {}

  logout() {
    this.as.logout();
    this.router.navigate(['login']);
  }
}
