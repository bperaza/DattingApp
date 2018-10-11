import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Input() valuesFromHome: any;
  @Output() cancelRegister = new EventEmitter();

  // empty Object
  model: any = {};
  constructor(private authServices: AuthService,
    private alertifyService: AlertifyService) { }

  ngOnInit() {
  }
  register () {
    this.authServices.register(this.model).subscribe( () => {
        this.alertifyService.success('Registration Successful');
    }, error => {
      this.alertifyService.error(error);
    });

  }

  cancel() {
    this.cancelRegister.emit(false);
    
  }

}
