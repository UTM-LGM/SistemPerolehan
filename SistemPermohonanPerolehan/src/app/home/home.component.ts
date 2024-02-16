import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { SharedService } from '../_services/shared.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  username = ''
  constructor(
    private toastr: ToastrService,
    private sharedService:SharedService
    ){}

    ngOnInit(): void {
      this.showUsername()
    }

    showUsername(){
      this.username = this.sharedService.username
      this.toastr.success('Welcome ' + this.username + ' !')
    }
}
