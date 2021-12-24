import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IndexComponent } from './web/index/index.component';
import { QuanlydonhangComponent } from './web/quanlydonhang/quanlydonhang.component';
import { QuanlyloaisanphamComponent } from './web/quanlyloaisanpham/quanlyloaisanpham.component';
import { QuanlynhacungcapComponent } from './web/quanlynhacungcap/quanlynhacungcap.component';
import { QuanlysanphamComponent } from './web/quanlysanpham/quanlysanpham.component';
import { ThemloaisanphamComponent } from './web/themloaisanpham/themloaisanpham.component';
import { ThemnhacungcapComponent } from './web/themnhacungcap/themnhacungcap.component';
import { ThemsanphamComponent } from './web/themsanpham/themsanpham.component';
import { XemdonhangComponent } from './web/xemdonhang/xemdonhang.component';

const routes: Routes = [
  {
    path:"index",
    component: IndexComponent
  },
  {
    path:"quanlyloaisanpham",
    component: QuanlyloaisanphamComponent
  },
  {
    path:"quanlysanpham",
    component: QuanlysanphamComponent
  },
  {
    path:"quanlynhacungcap",
    component: QuanlynhacungcapComponent
  },
  {
    path:"themsanpham",
    component: ThemsanphamComponent
  },
  {
    path:"themnhacungcap",
    component: ThemnhacungcapComponent
  },
  {
    path:"themloaisanpham",
    component: ThemloaisanphamComponent
  },
  {
    path: "quanlydonhang/:status",
    component: QuanlydonhangComponent
  },
  {
    path: "xemdonhang/:orderID",
    component: XemdonhangComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
