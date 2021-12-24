using System;

namespace Model
{
    public class itemGroup
    {
        public int key { get; set; }

        public int PARENT_ITEM_GROUP_ID { get; set; }
        public string label { get; set; }
        public int item_group_count { get; set; }

    }
}
