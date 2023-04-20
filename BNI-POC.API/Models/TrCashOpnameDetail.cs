using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class TrCashOpnameDetail
    {
        public int Id { get; set; }
        public int? CashOpnameId { get; set; }
        public int? Seq { get; set; }
        public int? DenomTypeId { get; set; }
        public decimal? OpnameAmount { get; set; }
        public DateTime? UpdDate { get; set; }
        public string? UpdBy { get; set; }
    }
}
