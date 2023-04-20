using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class TrCashOpname
    {
        public int Id { get; set; }
        public string? CashOpnameNo { get; set; }
        public DateTime? CashOpnameDate { get; set; }
        public int? UserBranchId { get; set; }
        public string? UnitType { get; set; }
        public int? BranchId { get; set; }
        public string? Longitude { get; set; }
        public string? Latitude { get; set; }
        public string? CheckingType { get; set; }
        public int? MediaTypeId { get; set; }
        public decimal? IconsTotalAmount { get; set; }
        public decimal? OpnameTotalAmount { get; set; }
        public string? PhotoPath { get; set; }
        public string? PhotoLongLat { get; set; }
        public decimal? DifferenceAmount { get; set; }
        public string? Status { get; set; }
        public DateTime? UpdDate { get; set; }
        public string? UpdBy { get; set; }
    }
}
