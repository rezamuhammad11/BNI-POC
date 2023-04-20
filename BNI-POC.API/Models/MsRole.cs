using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class MsRole
    {
        public int Id { get; set; }
        public string? RoleCode { get; set; }
        public string? RoleName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? UpdDate { get; set; }
        public string? UpdBy { get; set; }
    }
}
