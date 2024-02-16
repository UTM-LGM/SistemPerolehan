import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-home-layout',
  templateUrl: './home-layout.component.html',
  styleUrls: ['./home-layout.component.css']
})
export class HomeLayoutComponent {

  constructor(
    private router:Router,
    private toastr:ToastrService
  ){}
  
  logOut(){
    localStorage.removeItem('token')
    this.router.navigateByUrl('/login')
    this.toastr.success('Successfully Logout')
  }

}
