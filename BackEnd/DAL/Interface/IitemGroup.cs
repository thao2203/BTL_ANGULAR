﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IitemGroup
    {
        public object GetAllItemGroup();
        public object DelItemGroupByID(string id);
        public object ItemGroupTK();
    }
}
