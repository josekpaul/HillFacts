
using System;
using System.Collections.Generic;
using System.Text;

namespace ProPublicaCongressAPI.Contracts
{
    public class Amendment
    {
        public string Number { get; set; }

        public string Slug { get; set; }

        public string SponsorTitle { get; set; }

        public string Sponsor { get; set; }

        public string SponsorId { get; set; }

        public string SponsorUrl { get; set; }

        public string SponsorParty { get; set; }

        public string SponsorState { get; set; }

        public DateTime DateIntroduced { get; set; }

        public string Title { get; set; }

        public DateTime DateLatestMajorAction { get; set; }

        public string LatestMajorAction { get; set; }
    }
}
