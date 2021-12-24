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
        public static int id = 0;
        public void CheckOut(orders order, IEnumerable<orderDetail> cartData)
        {
            id = _dbHelper.getLastId(@"INSERT INTO ORDERS
                (
                 ORDER_NAME,
                 CREATED_DATE,
                 PHONE,
                 ADDRESS,
                 NOTE,
                 IDcookie,
                 STATUS
                )

                OUTPUT inserted.ORDER_ID
                VALUES
                (
                 '" + order.ORDER_NAME + @"',
                 getdate(),
                 '" + order.PHONE + @"',
                 '" + order.ADDRESS + @"',
                 '" + order.NOTE + @"',
                 '"+order.IDcookie+@"',
                 1
                )");
            CreateOrderDetail(cartData);
        }

        public object CreateOrderDetail(IEnumerable<orderDetail> od)
        {
            foreach(orderDetail i in od)
            {
                string Error = "";
                var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "orderDetail_create",
                    "@ORDER_ID", id,
                    "@ITEM_ID", i.ITEM_ID,
                    "@QUANTITY", i.QUANTITY,
                    "@PRICE", i.PRICE,
                    "@IMAGE", i.IMAGE,
                    "@TOTAL", i.TOTAL);
                if (!string.IsNullOrEmpty(Error))
                    return Error;
            }
            return null;
        }

        public object CreateOrder(orders data)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "orders_create",
                "@ORDER_NAME", data.ORDER_NAME,
                "@PHONE", data.PHONE,
                "@ADDRESS", data.ADDRESS,
                "@NOTE", data.NOTE);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return data;
        }

        public object getOrderByCookie(string cookie)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "sp_order_all", "@IDcookie", cookie);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<orders>().ToList();
        }

        public object OrderDetailByID(int id)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "orderDetail_ByID", "@ORDER_ID", id);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<orders>().ToList();
        }

        public object OrderByID(int id)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "order_ByID", "@ORDER_ID", id);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<orders>().FirstOrDefault();
        }

        public object OrderByStatus(int status)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "sp_order_all_status", "@STATUS", status);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<orders>().ToList();
        }

        public object OrderTK()
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "order_thongke");
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<orders>().FirstOrDefault();
        }

        public object UpdateStatus(int id)
        {
            string Error = "";
            var db1 = _dbHelper.ExecuteSProcedureReturnDataTable(out Error, "order_updateStatus", "@ORDER_ID", id);
            if (!string.IsNullOrEmpty(Error))
                return Error;
            return db1.ConvertTo<orders>().FirstOrDefault();
        }
    }
}
