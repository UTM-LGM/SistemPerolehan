import { Component, OnInit } from '@angular/core';
import { UserService } from '../_services/user.service';
import { User } from '../_interfaces/user';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  user ={} as User

  constructor(
    private userService:UserService,
    private router:Router
  ){}
  
  ngOnInit(): void {

  }

  login(){
    this.userService.loginUser(this.user)
    .subscribe(
      (Response:any)=>{
        localStorage.setItem('token', Response.token)
        this.router.navigateByUrl('/e-perolehan/home')
      }
    )
  }
}
