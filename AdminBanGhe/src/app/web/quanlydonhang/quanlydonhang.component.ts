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
  private status;
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

}
