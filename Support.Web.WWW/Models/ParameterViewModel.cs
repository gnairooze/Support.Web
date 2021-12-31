using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Support.Web.WWW.Models
{
    public class ParameterViewModel
    {
        public int Order { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public int MaxLength { get; set; }
        public bool IsOutput { get; set; }
        public bool Nullable { get; set; }
        public string Value { get; set; }
    }
}
