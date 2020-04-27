using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantLibrary.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiveId { get; set; }
        public string MessageText { get; set; }
        public DateTime SendDate { get; set; }
    }
}
