using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class UserLogs
    {
        public virtual Guid UserId { get; set; }

        public virtual Users user { get; set; }
        public virtual Guid DeviceId { get; set; }
        public virtual DateTime LoginTime { get; set; }

        public virtual int Status { get; set; }
    }
}