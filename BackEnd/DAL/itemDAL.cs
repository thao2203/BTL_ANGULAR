﻿using System;
using System.Collections.Generic;
using Model;
using DAL.Helper;
using System.Linq;
using DAL.Interface;
namespace DAL
{
    public class itemDAL:Iitem
    {
        private IDatabaseHelper _dbHelper;
        public itemDAL(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public object ngauNhien()
        {
                string Error = "";
                var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "sp_item_ngauNhien");
                var db2 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "sp_item_bestSeller");
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return Tuple.Create(db1.ConvertTo<items>().ToList(), db2.ConvertTo<items>().ToList());
            
        }

        public object ItemTK()
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "item_thongke");
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<items>().FirstOrDefault();
        }

        public object chiTiet(int id)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "sp_item_get_by_id", "@ITEM_ID", id);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<items>().FirstOrDefault();

        }

        public object sanPhamTuongTu(int id)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "sp_item_tuongTu_by_ID", "@ITEM_GROUP_ID", id);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<items>().ToList();
        }

        public object DSdanhMuc(int id)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "sp_item_get_by_category", "@ITEM_GROUP_ID", id);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<items>().ToList();

        }
        
        public object GetAllItems()
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "sp_item_all");
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<items>().ToList();
        }

        public object CreateItem(items data)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "sp_item_create", "@ITEM_GROUP_ID", data.ITEM_GROUP_ID, "@SUPPLIER_ID", data.SUPPLIER_ID, "@ITEM_IMAGE", data.ITEM_IMAGE, "@ITEM_NAME", data.ITEM_NAME, "@ITEM_PRICE", data.ITEM_PRICE, "@ITEM_DESCRIPTION", data.ITEM_DESCRIPTION);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return data;
        }
        public object DelItemByID(string id)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedure("sp_item_del", "@ITEM_ID", id);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return null;
        }

        public object UpdateItemByID(string id)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedure("sp_item_update", "@ITEM_ID", id);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return null;
        }
    }
}
