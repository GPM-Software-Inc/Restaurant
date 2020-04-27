using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RestaurantLibrary.Models
{
    public class Task
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        [MaxLength(100)]
        public string Themes { get; set; }
        public string TaskText { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime ExprireDate { get; set; }
        public bool IsExprired { get; set; }
    }
}
