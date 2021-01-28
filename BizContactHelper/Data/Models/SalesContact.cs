using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizContactHelper.Data.Models
{
    public class SalesContact : Contact
    {
        public DateTime FollowUpDate { get; set; }
    }
}
