using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizContactHelper.Data.Models
{
    public abstract class Contact : IQueryable
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set; }
    }
}
