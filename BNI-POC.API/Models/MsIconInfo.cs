using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class MsIconInfo
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public string? Atmid { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? RecordNo { get; set; }
        public decimal? Denom100 { get; set; }
        public decimal? Denom50 { get; set; }
        public decimal? Denom20 { get; set; }
        public DateTime? CutoffDate { get; set; }
        public bool? IsActive { get; set; }
        public string? RegisterNo { get; set; }
        public int? RegisterQty { get; set; }
        public string? Uom { get; set; }
    }
}
