using System;
using System.Collections.Generic;
using System.Text;
using Model;
namespace DAL.Interface
{
    public interface Iitem
    {
        public object ngauNhien();
        public object chiTiet(int id);
        public object DSdanhMuc(int id);
        public object TatCaNCC();
        public object GetAllItems();

        public object CreateItem(items data);
    }
}
