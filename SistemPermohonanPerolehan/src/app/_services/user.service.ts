import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../_interfaces/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  baseUrl = environment.apiUrl

  constructor(private http:HttpClient) { }

  registerUser(user:User):Observable<User>{
    return this.http.post<User>(this.baseUrl + '/applicationUsers/Register', user)
  }

  loginUser(user:User):Observable<User>{
    return this.http.post<User>(this.baseUrl + '/applicationUsers/Login', user)
  }

  getUser(username: string): Observable<User> {
    return this.http.get<User>(this.baseUrl + '/applicationusers/GetUser/' + username)
  }
}
