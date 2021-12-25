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
    public class OrdersController : Controller
    {
        private Iorders _db;
        public OrdersController(Iorders db)
        {
            _db = db;
        }

        [HttpPost]
        [Route("checkout")]
        public void checkout(object data)
        {
            object json = JsonConvert.DeserializeObject(data.ToString());
            var userDataJson = (JToken)JsonConvert.DeserializeObject(json.ToString());
            object userData = userDataJson["userdata"].Value<object>();
            orders order = JsonConvert.DeserializeObject<orders>(userData.ToString());
            object cartData = userDataJson["cart"].Value<object>();
            List<orderDetail> listDetails = JsonConvert.DeserializeObject<List<orderDetail>>(cartData.ToString());
            //_IBillBUS.CreateBill(bill);

            _db.CheckOut(order, listDetails);
        }

        [HttpPost]
        [Route("create-order")]

        public object createOrder(orders data)
        {
            return _db.CreateOrder(data);
        }

        [HttpGet]
        [Route("get-orderByCookie/{cookie}")]

        public object getOrderCookie(string cookie)
        {
            return _db.getOrderByCookie(cookie);
        }

        [HttpGet]
        [Route("get-orderByStatus/{status}")]

        public object getOrderStatus(int status)
        {
            return _db.OrderByStatus(status);
        }

        [HttpGet]
        [Route("get-orderDetailByID/{id}")]

        public object getOrderDetailByID(int id)
        {
            return _db.OrderDetailByID(id);
        }

        [HttpGet]
        [Route("get-orderByID/{id}")]

        public object getDetailByID(int id)
        {
            return _db.OrderByID(id);
        }

        [HttpGet]
        [Route("order-TK")]

        public object orderTK()
        {
            return _db.OrderTK();
        }

        [HttpPost]
        [Route("update-orderStatus/{id}/{status}")]

        public object updateOrderStatus(int id, int status)
        {
            return _db.UpdateStatus(id, status);
        }
    }
}
