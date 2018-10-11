import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  // Creamos un Objeto Vacio
  model: any = {};

  constructor(
    public authService: AuthService,
    private alertifyService: AlertifyService) { }

  ngOnInit() {
  }

  login () {
    this.authService.login(this.model).subscribe(next => {
        this.alertifyService.success('Logeado Exitosamente');
    }, error => {
      this.alertifyService.error(error);
    });
    // console.log(this.model);
  }

  loggedIn() {
    return this.authService.loggedIn();
  }

  logOut() {
    localStorage.removeItem('token');
    this.alertifyService.message('Logged Out');
  }
}
