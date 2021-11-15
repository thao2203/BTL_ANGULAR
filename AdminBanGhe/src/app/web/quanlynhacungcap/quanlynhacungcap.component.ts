import { Component, OnInit } from '@angular/core';
import { SystemService} from '../../share/system.service';
@Component({
  selector: 'app-quanlynhacungcap',
  templateUrl: './quanlynhacungcap.component.html',
  styleUrls: ['./quanlynhacungcap.component.css','../../../assets/css/main2.css']
})
export class QuanlynhacungcapComponent implements OnInit {
  constructor(private system : SystemService) { }

  suppliers:any = [];
  ngOnInit(): void {
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

}
