import { Component, OnInit } from '@angular/core';
import { SystemService } from '../../share/system.service';
import { TreeNode, MenuItem } from 'primeng/api';

@Component({
  selector: 'app-quanlyloaisanpham',
  templateUrl: './quanlyloaisanpham.component.html',
  styleUrls: ['./quanlyloaisanpham.component.css'],
})
export class QuanlyloaisanphamComponent implements OnInit {
  constructor(private system: SystemService) {}

  files: TreeNode[];

  selectedNode: TreeNode;

  cols: any[];

  items: MenuItem[];

  categories: any = [];
  listcate = [];
  ngOnInit(): void {
    this.system.getAllCategory().subscribe(
      (rep: any) => {
        rep.forEach((element) => {
          if (element.parenT_ITEM_GROUP_ID == 0) {
            element.children = [];
            this.createTreeMenu(element, rep);
          }
        });

        this.files = this.categories;
        console.log(this.categories);
      },
      (rep1: any) => {
        console.log(rep1);
      }
    );
  }

  createTreeMenu(elementHienTai, listcate) {
    for (let i = 0; i < listcate.length; i++) {
      if (elementHienTai.key == listcate[i].parenT_ITEM_GROUP_ID) {
        if (!elementHienTai.children) {
          elementHienTai.children = [];
        }

        elementHienTai.children.push(listcate[i]);
        if (
          elementHienTai.parenT_ITEM_GROUP_ID == 0 &&
          elementHienTai.children.length == 1
        ) {
          this.categories.push(elementHienTai);
        }

        this.createTreeMenu(listcate[i], listcate);
      }
    }
  }
  delete(s) {
    this.system.delItemGroupID(s).subscribe((rep:any)=>{
      location.reload();
    }, (rep1: any)=>{
      console.log(rep1);
    }
    )
  }
}
