using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class MsMediaType
    {
        public int Id { get; set; }
        public string? MediaTypeCode { get; set; }
        public string? MediaTypeName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? UpdDate { get; set; }
        public string? UpdBy { get; set; }
    }
}
