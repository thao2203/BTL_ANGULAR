import { Component, OnInit } from '@angular/core';
import { SystemService} from '../../share/system.service';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
@Component({
  selector: 'app-xemdonhang',
  templateUrl: './xemdonhang.component.html',
  styleUrls: ['./xemdonhang.component.css']
})
export class XemdonhangComponent implements OnInit {
  private a:Subscription;
  constructor(private system : SystemService, private router:ActivatedRoute) { }

  order;
  orderDetail=[];
  private id;
  sum=0;

  ngOnInit(): void {
    this.a = this.router.params.subscribe(x=>{
      this.id = x["orderID"];
    });
    this.system.getOrderDetail(this.id).subscribe(
      (rep:any)=>
      {
        this.orderDetail = rep;
        for(var i=0; i<rep.length;i++)
        {
          this.sum+=rep[i].total;
        }
        console.log(rep);
      },(rep1:any)=>
      {

        console.log(rep1)
      }
    )
    this.system.getOrder(this.id).subscribe(
      (rep:any)=>
      {
        this.order = rep;
        console.log(rep);
      },(rep1:any)=>
      {

        console.log(rep1)
      }
    )
  }

}
