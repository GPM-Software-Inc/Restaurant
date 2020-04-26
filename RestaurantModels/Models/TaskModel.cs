using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantModels.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiveId { get; set; }
        public string TaskText { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime ExprireDate { get; set; }
    }
}
