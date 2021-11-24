using Microsoft.AspNetCore.Mvc;
using DAL.Interface;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace btlBanGhe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class itemController : ControllerBase
    {
        private Iitem _db;
        public itemController(Iitem db)
        {
            _db = db;
        }

        

        [HttpGet]
        [Route("get-random")]

        public object getRandom()
        {
            return _db.ngauNhien();
        }

        [HttpGet]
        [Route("get-detail/{id}")]

        public object getDetail(int id)
        {
            return _db.chiTiet(id);
        }

        [HttpGet]
        [Route("item-TK")]

        public object itemTK()
        {
            return _db.ItemTK();
        }

        [HttpGet]
        [Route("get-spTuongTu/{id}")]

        public object getSPTuongTu(int id)
        {
            return _db.sanPhamTuongTu(id);
        }

        [HttpGet]
        [Route("get-category/{id}")]

        public object getCategory(int id)
        {
            return _db.DSdanhMuc(id);
        }

        [HttpGet]
        [Route("get-allItem")]

        public object getAllItems()
        {
            return _db.GetAllItems();
        }

        [HttpPost]
        [Route("create-item")]

        public object createItem(items data)
        {
            return _db.CreateItem(data);
        }

        [HttpGet]
        [Route("delItem/{id}")]
        public object DelItemByID(string id)
        {
            return _db.DelItemByID(id);
        }
    }
}
