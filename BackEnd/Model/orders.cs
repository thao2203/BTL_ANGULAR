using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class orders
    {
        public int ORDER_ID { get; set; }
        public string IDcookie { get; set; }
        public string ORDER_NAME { get; set; }
        public DateTime CREATED_DATE { get; set; }

        public string PHONE { get; set; }
        public string ADDRESS { get; set; }
        public string NOTE { get; set; }

        public string ITEM_NAME { get; set; }
        public float QUANTITY { get; set; }
        public float TOTAL { get; set; }
        public int STATUS { get; set; }
        public int order_count { get; set; }
    }
}
