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

            _db.CheckOut(order, cartData);
        }
    }
}
