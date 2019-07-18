using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NT_MVC_Task.Models
{
    public class Movies
    {
        public int id { get; set; }
        public String name { get; set; }
        public List<Customers> cust_list { get; set; }
    }
}