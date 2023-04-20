using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class TrAtmOpname
    {
        public int Id { get; set; }
        public string AtmOpnameNo { get; set; } = null!;
        public string RegionId { get; set; } = null!;
        public string BranchId { get; set; } = null!;
        public string UnitType { get; set; } = null!;
        public DateTime AtmOpnameDate { get; set; }
        public string LocationLongitude { get; set; } = null!;
        public string AtmId { get; set; } = null!;
        public decimal AtmBeginAmount { get; set; }
        public decimal AdminInputAmount { get; set; }
        public decimal AtmBillAmount { get; set; }
        public decimal AtmOpnameAmount { get; set; }
        public string? NotesDifferenceBillAmount { get; set; }
        public decimal DifferenceAmount { get; set; }
        public string PhotoPath { get; set; } = null!;
        public string PhotoLongitude { get; set; } = null!;
        public DateTime UpdDate { get; set; }
        public string UpdBy { get; set; } = null!;
        public decimal TotalAmount { get; set; }
    }
}
