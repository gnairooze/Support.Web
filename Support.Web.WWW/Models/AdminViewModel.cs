using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Support.Web.WWW.Models
{
    public class AdminViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Module { get; set; }
        public string Description { get; set; }
        public bool RetrunsData { get; set; }
    }
}
