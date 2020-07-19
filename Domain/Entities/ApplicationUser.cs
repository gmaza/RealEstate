using Domain.Common;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class ApplicationUser
    {
        public Guid Id { get; set; }
        public Guid IdentityUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public ICollection<Listing> Listings { get; set; }
        public ICollection<FavoriteListing> FavoriteListings { get; set; }
    }
}
