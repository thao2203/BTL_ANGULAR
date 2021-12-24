using System;
using System.Collections.Generic;
using Model;
using DAL.Helper;
using System.Linq;
using DAL.Interface;

namespace DAL
{
    public class itemGroupDAL:IitemGroup
    {
        private IDatabaseHelper _dbHelper;
        public itemGroupDAL(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public object GetAllItemGroup()
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "sp_item_group_all");
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<itemGroup>().ToList();
        }
        
        public object DelItemGroupByID(string id)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedure("sp_item_group_del", "@ITEM_GROUP_ID", id);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return null;
        }

        public object ItemGroupTK()
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "itemGroup_thongke");
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<itemGroup>().FirstOrDefault();
        }

        public object CreateItemGroup(itemGroup data)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "sp_item_group_create", "@PARENT_ITEM_GROUP_ID", data.PARENT_ITEM_GROUP_ID, "@ITEM_GROUP_NAME", data.label, "@ITEM_IMAGE");
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return data;
        }
    }
}
