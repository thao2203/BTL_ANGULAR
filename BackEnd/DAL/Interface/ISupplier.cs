using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL.Interface
{
    public interface ISupplier
    {
        public object TatCaNCC();
        public object CreateSupplier(supplier data);
        public object DelSupplierByID(string id);
    }
}



