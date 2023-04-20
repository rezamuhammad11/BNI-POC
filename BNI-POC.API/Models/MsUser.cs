using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class MsUser
    {
        public string Username { get; set; } = null!;
        public int? RoleId { get; set; }
        public int? BranchId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? UpdDate { get; set; }
        public string? UpdBy { get; set; }
    }
}
