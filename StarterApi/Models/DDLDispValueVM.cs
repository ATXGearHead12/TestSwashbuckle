using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarterApi.Models
{
    public class DDLDispValueVM
    {
        public string Disp { get; set; }
        public string Value { get; set; }
        public Int32 SortOrder { get; set; }
        public Int32 IsChecked { get; set; }
    }
}