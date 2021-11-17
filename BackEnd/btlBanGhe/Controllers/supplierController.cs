using Microsoft.AspNetCore.Mvc;
using DAL.Interface;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace btlBanGhe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class supplierController : ControllerBase
    {
        private ISupplier _db;
        public supplierController(ISupplier db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("get-allSupplier")]

        public object getAllSupplier()
        {
            return _db.TatCaNCC();
        }
        [HttpPost]
        [Route("create-supplier")]

        public object createItem(supplier data)
        {
            return _db.CreateSupplier(data);
        }
        [HttpGet]
        [Route("delSupplier/{id}")]
        public object DelSupplierID(string id)
        {
            return _db.DelSupplierByID(id);
        }
    }
}