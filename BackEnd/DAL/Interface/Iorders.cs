using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL.Interface
{
    public interface Iorders
    {
        public void CheckOut(orders order, IEnumerable<orderDetail> cartData);
        public object CreateOrder(orders data);
        public object CreateOrderDetail(IEnumerable<orderDetail> od);
        public object getOrderByCookie(string cookie);
        public object OrderDetailByID(int id);
        public object OrderByID(int id);
        public object OrderByStatus(int status);
        public object OrderTK();
        public object UpdateStatus(int id);
    }
}
