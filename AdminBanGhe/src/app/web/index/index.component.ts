import { Component, OnInit } from '@angular/core';
import { SystemService} from '../../share/system.service';
@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {

  constructor(private system: SystemService) { }
  item;
  itemGroup;
  supplier;
  ngOnInit(): void {
    this.system.TkItem().subscribe(
      (rep:any)=>
      {
        this.item = rep;
        console.log(rep)
      },(rep1:any)=>
      {
        console.log(rep1)
      }
    )
    this.system.TkItemGroup().subscribe(
      (rep:any)=>
      {
        this.itemGroup = rep;
        console.log(rep)
      },(rep1:any)=>
      {
        console.log(rep1)
      }
    )
    this.system.TkSupplier().subscribe(
      (rep:any)=>
      {
        this.supplier = rep;
        console.log(rep)
      },(rep1:any)=>
      {
        console.log(rep1)
      }
    )
  }

}
