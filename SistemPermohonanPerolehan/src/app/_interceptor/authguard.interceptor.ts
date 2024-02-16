import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { ActivatedRouteSnapshot, CanActivate, Router } from '@angular/router';
import jwt_decode from 'jwt-decode';
import { SharedService } from '../_services/shared.service';
import { UserService } from '../_services/user.service';

@Injectable({
  providedIn: 'root',
})

export class AuthguardInterceptor implements CanActivate {

  username = ''
  constructor(
    private router:Router,
    private sharedService:SharedService,
    private userService:UserService
  ) {}

  canActivate(next: ActivatedRouteSnapshot): Observable<boolean> {
    const token =localStorage.getItem('token')
    if(token != null )
    {
      //deserialize Token JWT
      const decodedToken: any = jwt_decode(token)
      this.username = decodedToken.Username
      this.sharedService.username = this.username
      
      //check jwt expired time
      const currentTime = new Date().getTime()
      //*1000 to convert milisecond
      if(decodedToken.exp * 1000 < currentTime)
      {
        this.router.navigateByUrl('/login');
        return of(false)
      }
      else{
        this.getUser(this.username)
        return of(true)
      }
    }
    else
    {
      this.router.navigateByUrl('/login');
      return of (false);
    }
  }

  getUser(username:string){
    this.userService.getUser(username)
    .subscribe(
      Response =>{
        this.sharedService.userId = Response.id.toString()
      }
    )
  }
}
