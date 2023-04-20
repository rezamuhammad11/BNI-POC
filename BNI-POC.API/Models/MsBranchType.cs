using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class MsBranchType
    {
        public int Id { get; set; }
        public string? BranchTypeCode { get; set; }
        public string? BranchTypeName { get; set; }
        public int? BranchTypeLevel { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? UpdDate { get; set; }
        public string? UpdBy { get; set; }
    }
}
