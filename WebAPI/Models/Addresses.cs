using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Addresses
    {
        public Guid AddressId { get; set; }
        public String location { get; set; }
        public String contact { get; set; }

    }
}