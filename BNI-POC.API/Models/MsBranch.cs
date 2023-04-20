using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class MsBranch
    {
        public int Id { get; set; }
        public string? BranchCode { get; set; }
        public string? BranchName { get; set; }
        public int? BranchTypeId { get; set; }
        public int? ParentBranchId { get; set; }
        public bool? IsPut { get; set; }
        public bool? IsPnc { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? UpdDate { get; set; }
        public string? UpdBy { get; set; }
    }
}
