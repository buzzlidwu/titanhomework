using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork.Models
{
    public class Detail
    {
        [Key]
        [Display(Name = "#")]
        public int Id { get; set; }
        [Display(Name = "類別")]
        public string Type { get; set; }
        [Display(Name = "日期")]
        public string DateTime { get; set; }
        [Display(Name = "金額")]
        public Decimal Cost { get; set; }
    }
}