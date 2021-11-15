import { Component, OnInit } from '@angular/core';
import { SystemService } from 'src/app/share/system.service';
@Component({
  selector: 'app-themsanpham',
  templateUrl: './themsanpham.component.html',
  styleUrls: ['./themsanpham.component.css']
})
export class ThemsanphamComponent implements OnInit {

  constructor(public system:SystemService) { }

  ngOnInit(): void {
    
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
