import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from "@angular/common/http";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './layout/header/header.component';
import { SidebarComponent } from './layout/sidebar/sidebar.component';
import { IndexComponent } from './web/index/index.component';
import { FooterComponent } from './layout/footer/footer.component';
import { QuanlyloaisanphamComponent } from './web/quanlyloaisanpham/quanlyloaisanpham.component';
import { QuanlysanphamComponent } from './web/quanlysanpham/quanlysanpham.component';
import { QuanlynhacungcapComponent } from './web/quanlynhacungcap/quanlynhacungcap.component';
import {TreeModule} from 'primeng/tree';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { ThemsanphamComponent } from './web/themsanpham/themsanpham.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SidebarComponent,
    IndexComponent,
    FooterComponent,
    QuanlyloaisanphamComponent,
    QuanlysanphamComponent,
    QuanlynhacungcapComponent,
    ThemsanphamComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    TreeModule,
    FormsModule,
    ReactiveFormsModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
