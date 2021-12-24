import { Component, OnInit } from '@angular/core';
import { SystemService } from '../../share/system.service';
@Component({
  selector: 'app-themsanpham',
  templateUrl: './themsanpham.component.html',
  styleUrls: ['./themsanpham.component.css']
})
export class ThemsanphamComponent implements OnInit {

  constructor(public system:SystemService) { }
  categories=[];
  suppliers=[];
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

    this.system.getSupplier().subscribe(
      (rep:any)=>
      {
        this.suppliers = rep;
        console.log(rep)
      },(rep1:any)=>
      {
        console.log(rep1)
      }
    )
  }

  
  
  submit(){
      this.system.createItem().subscribe(
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
