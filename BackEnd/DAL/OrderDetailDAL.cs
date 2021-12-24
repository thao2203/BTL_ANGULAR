using System;
using System.Collections.Generic;
using Model;
using DAL.Helper;
using System.Linq;
using DAL.Interface;

namespace DAL
{
    public class OrderDetailDAL : IorderDetail
    {
        private IDatabaseHelper _dbHelper;
        public OrderDetailDAL(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public object CreateOrderDetail(orderDetail data)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "orderDetail_create",
                "@ORDER_ID", data.ORDER_ID, 
                "@ITEM_ID", data.ITEM_ID, 
                "@QUANTITY", data.QUANTITY, 
                "@PRICE", data.PRICE, 
                "@IMAGE", data.IMAGE, 
                "@TOTAL", data.TOTAL);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return data;
        }


    }
}
