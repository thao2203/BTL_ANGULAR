using System;
using System.Collections.Generic;
using Model;
using DAL.Helper;
using System.Linq;
using DAL.Interface;

namespace DAL
{
    public class SupplierDAL : Isupplier
    {
        private IDatabaseHelper _dbHelper;
        public SupplierDAL(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public object TatCaNCC()
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "supplier_all");
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<supplier>().ToList();

        }
        public object CreateSupplier(supplier data)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "supplier_create", "@SUPPLIER_NAME", data.SUPPLIER_NAME, "@SUPPLIER_ADDRESS", data.SUPPLIER_ADDRESS, "@SUPPLIER_PHONE", data.SUPPLIER_PHONE);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return data;
        }
        public object DelSupplierByID(string id)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedure("supplier_del", "@ID", id);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return null;
        }
        public object SupplierTK()
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "Supplier_thongke");
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<supplier>().FirstOrDefault();
        }
    }
}
