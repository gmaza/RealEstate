using Application.Common.Models;
using System.Collections.Generic;

namespace Application.Listings.Queries.GetListingsForLP
{
    public class LookupDto
    {
        public List<IdName> OfferTypes { get; set; }
        public List<IdName> PropertyTypes { get; set; }
        public List<IdName> PropertyLayouts { get; set; }
        public List<IdName> BuildingTypes { get; set; }
        public List<IdName> OwnershipTypes { get; set; }
        public List<IdName> PropertyConditions { get; set; }
        public List<IdName> LandTypes { get; set; }
        public List<IdName> Furnishings { get; set; }
        public List<IdName> EnergyCertificates { get; set; }
        public List<IdName> PropertyFeatures { get; set; }
    }
}
