using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCEntityFrameworkDemo.Models
{
    public class DepartmentTotals
    {
        public string Name { get; set; }
        public int Total { get; set; }
    }
}