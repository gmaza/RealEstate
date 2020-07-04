namespace Domain.Entities
{
    public class ListingFeature
    {
        public long ListingId { get; set; }
        public Listing Listing { get; set; }
        public int PropertyFeatureId { get; set; }
        public PropertyFeature PropertyFeature { get; set; }
    }
}
