import { Component, OnInit } from '@angular/core';
import { SystemService } from '../../share/system.service';

@Component({
  selector: 'app-themloaisanpham',
  templateUrl: './themloaisanpham.component.html',
  styleUrls: ['./themloaisanpham.component.css']
})
export class ThemloaisanphamComponent implements OnInit {

  constructor(public system:SystemService) { }
  categories=[];
  ngOnInit(): void {
    this.system.getAllCategory().subscribe(
      (rep:any)=>
      {
        this.categories = rep;
        console.log(rep)
      },(rep1:any)=>
      {
        console.log(rep1)
      }
    )
  }

  submit(){
    this.system.createCategory().subscribe(
      (rep:any)=>
      {
        console.log(rep)
      },(rep1:any)=>
      {
        console.log(rep1)
      }
    )
}
}
