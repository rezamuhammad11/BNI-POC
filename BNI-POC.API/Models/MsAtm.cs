using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class MsAtm
    {
        public int Id { get; set; }
        public string? AtmCode { get; set; }
        public string? IpAtm { get; set; }
        public string? Location { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? UpdDate { get; set; }
        public string? UpdBy { get; set; }
    }
}
