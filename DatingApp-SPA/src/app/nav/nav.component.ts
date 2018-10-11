import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  // Creamos un Objeto Vacio
  model: any = {};

  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  login () {
    this.authService.login(this.model).subscribe(next => {
        console.log('Logeado Exitosamente');
    }, error => {
        console.log('No se pudo Logear Fracaso');
    });
    // console.log(this.model);
  }

  loggedIn() {
    const token = localStorage.getItem('token');
    return !!token;
  }

  logOut() {
    localStorage.removeItem('token');
    console.log('Logged Out');
  }
}
