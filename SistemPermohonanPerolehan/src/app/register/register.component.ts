import { Component, OnInit } from '@angular/core';
import { User } from '../_interfaces/user';
import { UserService } from '../_services/user.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  user = {} as User

  constructor(
    private userService:UserService,
  ){}

  ngOnInit(): void {
    
  }

  register(){
    this.userService.registerUser(this.user)
    .subscribe(
      Response=>{
        console.log("Done")
      }
    )
  }
}
