using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizContactHelper.Data.Models
{
    public class DeveloperContact : Contact
    {
        public Languages StrongestLanguage { get; set; }
    }
}
