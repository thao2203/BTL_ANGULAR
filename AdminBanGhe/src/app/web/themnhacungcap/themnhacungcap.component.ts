import { Component, OnInit } from '@angular/core';
import { SystemService } from 'src/app/share/system.service';
@Component({
  selector: 'app-themnhacungcap',
  templateUrl: './themnhacungcap.component.html',
  styleUrls: ['./themnhacungcap.component.css']
})
export class ThemnhacungcapComponent implements OnInit {

  constructor(public system:SystemService) { }

  ngOnInit(): void {
  }
  submit(){
    this.system.createSupplier().subscribe(
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
