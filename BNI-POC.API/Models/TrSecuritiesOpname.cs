using System;
using System.Collections.Generic;

namespace BNI_POC.API.Models
{
    public partial class TrSecuritiesOpname
    {
        public int Id { get; set; }
        public string SecuritiesNo { get; set; } = null!;
        public string SecuritiesType { get; set; } = null!;
        public int RegisterAmount { get; set; }
        public int PhysicalAmount { get; set; }
        public string Unit { get; set; } = null!;
        public string PhotoPath { get; set; } = null!;
        public string PhotoLongitude { get; set; } = null!;
        public DateTime UpdDate { get; set; }
        public string UpdBy { get; set; } = null!;
    }
}
