using System;
using System.Collections.Generic;
using Model;
using DAL.Helper;
using System.Linq;
using DAL.Interface;
        
namespace DAL
{
    public class ordersDAL : Iorders
    {
        private IDatabaseHelper _dbHelper;
        public ordersDAL(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public void CheckOut(orders order, object cartData)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "sp_order_create",
                "@ORDER_ID", order.ORDER_ID,
                "@ORDER_NAME", order.ORDER_NAME,
                "@PHONE", order.PHONE,
                "@ADDRESS", order.ADDRESS,
                "@listjson_chitiet", cartData);
        }
    }
}
