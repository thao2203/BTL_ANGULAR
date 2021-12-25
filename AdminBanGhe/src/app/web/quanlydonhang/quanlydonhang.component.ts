import { Component, OnInit } from '@angular/core';
import { SystemService} from '../../share/system.service';
import { Subscription } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-quanlydonhang',
  templateUrl: './quanlydonhang.component.html',
  styleUrls: ['./quanlydonhang.component.css']
})
export class QuanlydonhangComponent implements OnInit {
  private a:Subscription;
  constructor(private system: SystemService, private router:ActivatedRoute) { }

  orders:any=[];
  public status;
  public idOrder;
  public statusOrder;
  ngOnInit(): void {
    this.a = this.router.params.subscribe(x=>{
      this.status = x["status"];
    });
    this.system.getOrderStatus(this.status).subscribe(
      (rep:any)=>
      {
        this.orders = rep;
        console.log(rep);
      },(rep1:any)=>
      {
        console.log(rep1)
      }
    )

   

    
  }
  getValue(value){   
    var a = value;
    var splitFile : any;
    splitFile = [];
    splitFile= a.split('-');
    this.idOrder= splitFile[1];
    this.statusOrder= splitFile[0];
    console.log("id: "+ this.idOrder);
    console.log("status: "+ this.statusOrder);


    this.system.updateStatus(this.idOrder, this.statusOrder).subscribe(
      (rep:any)=>
      {
        //this.orders = rep;
        window.location.reload();
        console.log(rep);
      },(rep1:any)=>
      {
        console.log(rep1)
      }
    )
    // setTimeout(function(){
    // },3000);
  }
}
