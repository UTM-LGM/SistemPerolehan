import { Component, OnInit } from '@angular/core';
import { JenisPerolehan } from 'src/app/_interfaces/jenisPerolehan';
import { SharedService } from 'src/app/_services/shared.service';
import swal from 'sweetalert2'

@Component({
  selector: 'app-jenis-perolehan',
  templateUrl: './jenis-perolehan.component.html',
  styleUrls: ['./jenis-perolehan.component.css']
})
export class JenisPerolehanComponent implements OnInit{

  jenisPerolehan:JenisPerolehan = {} as JenisPerolehan

  constructor(
    private sharedService:SharedService
  ){}

  ngOnInit(): void {
    this.resetForm()
  }

  resetForm(){
    this.jenisPerolehan = {} as JenisPerolehan
    this.jenisPerolehan.Jenis = ''
  }

  simpan(){
    if(this.jenisPerolehan.Jenis == ''){
      swal.fire({
        text: 'Sila isi borang',
        icon: 'error'
      });
    }
    else{
      this.jenisPerolehan.isAtive = true
      this.jenisPerolehan.CreatedBy = this.sharedService.userId
      this.jenisPerolehan.CreatedDate = new Date()
      
    }
  }

}
