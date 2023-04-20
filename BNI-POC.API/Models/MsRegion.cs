using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class MsRegion
    {
        public int Id { get; set; }
        public string? RegionCode { get; set; }
        public string? RegionName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? UpdDate { get; set; }
        public string? UpdBy { get; set; }
    }
}
