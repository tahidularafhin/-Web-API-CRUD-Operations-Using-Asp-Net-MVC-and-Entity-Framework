﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Mvc.Models
{
    public class mvcEmployeeModel
    {

        public int EmployeeID { get; set; }
        [Required(ErrorMessage ="This Field is Required")]
        public string Name { get; set; }
        public string Position { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}