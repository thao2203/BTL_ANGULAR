using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL.Interface
{
    public interface Iorders
    {
        public void CheckOut(orders order, object cartData);
    }
}
