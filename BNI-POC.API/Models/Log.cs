using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class Log
    {
        public int Id { get; set; }
        public string? Log1 { get; set; }
        public int? Num { get; set; }
        public bool Flag { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
