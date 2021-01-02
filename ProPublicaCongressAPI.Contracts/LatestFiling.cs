using System;
using System.Collections.Generic;
using System.Text;

namespace ProPublicaCongressAPI.Contracts
{
    public class LatestFiling
    {
        public string filing_date { get; set; }
        public string report_year { get; set; }
        public string report_type { get; set; }
        public string pdf_url { get; set; }
    }
}
