import { Component, OnInit } from '@angular/core';
import { DatePipe, Location } from '@angular/common';
import { PermohonanPerolehan } from '../_interfaces/permohonanPerolehan';

@Component({
  selector: 'app-daftar-permohonan',
  templateUrl: './daftar-permohonan.component.html',
  styleUrls: ['./daftar-permohonan.component.css']
})
export class DaftarPermohonanComponent implements OnInit {

  permohonan:PermohonanPerolehan = {} as PermohonanPerolehan

  constructor(
    private location: Location,
    public datePipe: DatePipe
  ){}

  ngOnInit(){
    this.resetForm();
  }

  resetForm(){
    this.permohonan = {} as PermohonanPerolehan
    this.permohonan.JenisPerolehan = "0"
    this.permohonan.TarikhPermohonan = new Date()
  }

  back(){
    this.location.back()
  }

  simpan(){
    console.log(this.permohonan)
  }
}
