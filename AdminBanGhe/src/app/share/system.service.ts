import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../environments/environment';
import { FormBuilder, Validators } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class SystemService {
  private host = environment.hiiii;
  public SaveForm = this.form.group({
    tenSP : ["",[Validators.required, Validators.minLength(8)]],
    giaSP : ["",[Validators.required, Validators.min(0), Validators.max(900000)]],
    hinhAnh : [""],
    moTa : [""],
    loaiSP: ["",[Validators.required]],
    nccSP: ["",[Validators.required]]
  });
  constructor(private http: HttpClient, private form: FormBuilder) { }
  getAllItems(){
    return this.http.get(this.host+"item/get-AllItem", {responseType:"json"})
  }
  getAllCategory(){
    return this.http.get(this.host+"itemGroup/get-allItemGroup", {responseType:"json"})
  }
  getSupplier(){
    return this.http.get(this.host+"item/get-allSupplier", {responseType:"json"})
  }
  delItemGroupID(id){
    return this.http.get(this.host+"itemGroup/delItemGroup/"+id, {responseType:"json"})
  }
  createItem(){
    var data={
      ITEM_NAME: this.SaveForm.value.tenSP,
      ITEM_IMAGE: this.SaveForm.value.hinhAnh,
      ITEM_DESCRIPTION: this.SaveForm.value.moTa,
      ITEM_PRICE: this.SaveForm.value.giaSP,
      SUPPLIER_ID: this.SaveForm.value.nccSP,
      ITEM_GROUP_ID: this.SaveForm.value.loaiSP
    };
    console.log(data);
    return this.http.post(this.host+"item/create-item",data, {responseType:"json"})
  }
}
