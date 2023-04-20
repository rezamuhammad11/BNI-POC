using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class MsApprovalMatrix
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public int? RoleId { get; set; }
        public int? ApprovalRoleId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? UpdDate { get; set; }
        public string? UpdBy { get; set; }
    }
}
