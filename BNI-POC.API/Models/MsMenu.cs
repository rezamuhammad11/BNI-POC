using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class MsMenu
    {
        public int Id { get; set; }
        public string? MenuCode { get; set; }
        public string? MenuName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? UpdDate { get; set; }
        public string? UpdBy { get; set; }
    }
}
