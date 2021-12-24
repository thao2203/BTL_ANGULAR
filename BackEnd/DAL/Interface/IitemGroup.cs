using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL.Interface
{
    public interface IitemGroup
    {
        public object GetAllItemGroup();
        public object DelItemGroupByID(string id);
        public object ItemGroupTK();
        public object CreateItemGroup(itemGroup data);
        
    }
}
