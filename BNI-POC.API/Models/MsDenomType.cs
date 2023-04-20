using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class MsDenomType
    {
        public int Id { get; set; }
        public string? DenomTypeCode { get; set; }
        public string? DenomTypeName { get; set; }
        public string? DenomType { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? UpdDate { get; set; }
        public string? UpdBy { get; set; }
    }
}
