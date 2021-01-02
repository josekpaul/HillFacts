using System;
using System.Collections.Generic;
using System.Text;

namespace ProPublicaCongressAPI.Contracts
{
    public class LobbyingRepresentation
    {
        public LobbyingClient lobbying_client { get; set; }
        public LobbyingRegistrant lobbying_registrant { get; set; }
        public string inhouse { get; set; }
        public string signed_date { get; set; }
        public string effective_date { get; set; }
        public string xml_filename { get; set; }
        public string id { get; set; }
        public List<string> specific_issues { get; set; }
        public string report_type { get; set; }
        public string report_year { get; set; }
        public string senate_id { get; set; }
        public string house_id { get; set; }
        public LatestFiling latest_filing { get; set; }
        public List<Lobbyist> lobbyists { get; set; }
    }
}
