using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
using DAL.Interface;

namespace btlBanGhe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class orderDetailController : ControllerBase
    {
        private IorderDetail _db;
        public orderDetailController(IorderDetail db)
        {
            _db = db;
        }

        [HttpPost]
        [Route("create-orderDetail")]

        public object createOrderDetail(orderDetail data)
        {
            return _db.CreateOrderDetail(data);
        }


    }
}
