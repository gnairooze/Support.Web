using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Support.Web.WWW.Models
{
    public class ItemViewModel : AdminViewModel
    {
        public ItemViewModel()
        {
            this.Parameters = new List<ParameterViewModel>();
        }
        public List<ParameterViewModel> Parameters { get; }
        public DataSet ResultData { get; set; }
    }
}
