using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class TrainingLog
    {
        public int Id { get; set; }
        public string? Customername { get; set; }
        public string? Identityno { get; set; }
        public DateTime? Logdate { get; set; }
    }
}
