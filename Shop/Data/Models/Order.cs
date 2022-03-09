using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name ="First Name")]
        [MinLength(2)]
        [Required(ErrorMessage = "The name must be at least 2 characters long")]
        public string name { get; set; }

        [Display(Name = "Last Name")]
        [MinLength(2)]
        [Required(ErrorMessage = "The last name must be at least 2 characters long")]
        public string lastName { get; set; }

        [Display(Name = "Address")]
        [MinLength(2)]
        [Required(ErrorMessage = "The last name must be at least 2 characters long")]
        public string adress { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Incorrect phone number")]
        public string phone { get; set; }

        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Incorrect e-mail address")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetail { get; set; }
    }
}
