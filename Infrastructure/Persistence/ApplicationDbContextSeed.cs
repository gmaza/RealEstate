using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContextSeed
    {
        
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.OfferTypes.Any())
            {
                List<OfferType> offerTypes = new List<OfferType>
                {
                    new OfferType
                    {
                        Id = 1,
                        NameCZ = "",
                        NameEN = "Sale",
                        NameRU = ""
                    },

                    new OfferType
                    {
                        Id = 2,
                        NameCZ = "",
                        NameEN = "Rent",
                        NameRU = ""
                    },

                    new OfferType
                    {
                        Id = 3,
                        NameCZ = "",
                        NameEN = "Share",
                        NameRU = ""
                    },
                };

                context.OfferTypes.AddRange(offerTypes);
                context.SaveChanges();
            }

            if (!context.PropertyTypes.Any())
            {
                List<PropertyType> propertyTypes = new List<PropertyType>
                {
                    new PropertyType
                    {
                        Id = 1,
                        NameCZ = "",
                        NameEN = "Flat",
                        NameRU = ""
                    },

                    new PropertyType
                    {
                        Id = 2,
                        NameCZ = "",
                        NameEN = "House",
                        NameRU = ""
                    },

                    new PropertyType
                    {
                        Id = 3,
                        NameCZ = "",
                        NameEN = "Plot",
                        NameRU = ""
                    },

                    new PropertyType
                    {
                        Id = 4,
                        NameCZ = "",
                        NameEN = "Garage",
                        NameRU = ""
                    },

                    new PropertyType
                    {
                        Id = 5,
                        NameCZ = "",
                        NameEN = "Office",
                        NameRU = ""
                    },

                    new PropertyType
                    {
                        Id = 6,
                        NameCZ = "",
                        NameEN = "Non-residential property",
                        NameRU = ""
                    },

                    new PropertyType
                    {
                        Id = 7,
                        NameCZ = "",
                        NameEN = "Recreational property",
                        NameRU = ""
                    },
                };

                context.PropertyTypes.AddRange(propertyTypes);
                context.SaveChanges();
            }

            if (!context.PropertyLayouts.Any())
            {
                List<PropertyLayout> propertyLayouts = new List<PropertyLayout>
                {
                    new PropertyLayout
                    {
                        Id = 1,
                        NameCZ = "",
                        NameEN = "Small studio",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 2,
                        NameCZ = "",
                        NameEN = "Studio",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 3,
                        NameCZ = "",
                        NameEN = "1 bedroom",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 4,
                        NameCZ = "",
                        NameEN = "1 bedroom with open-plan kitchen",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 5,
                        NameCZ = "",
                        NameEN = "2 bedrooms",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 6,
                        NameCZ = "",
                        NameEN = "2 bedrooms with open-plan kitchen",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 7,
                        NameCZ = "",
                        NameEN = "3 bedrooms",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 8,
                        NameCZ = "",
                        NameEN = "3 bedrooms with open-plan kitchen",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 9,
                        NameCZ = "",
                        NameEN = "4 bedrooms",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 10,
                        NameCZ = "",
                        NameEN = "4 bedrooms with open-plan kitchen",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 11,
                        NameCZ = "",
                        NameEN = "5 bedrooms",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 12,
                        NameCZ = "",
                        NameEN = "5 bedrooms with open-plan kitchen",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 13,
                        NameCZ = "",
                        NameEN = "6 bedrooms",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 14,
                        NameCZ = "",
                        NameEN = "6 bedrooms with open-plan kitchen",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 15,
                        NameCZ = "",
                        NameEN = "7 bedrooms",
                        NameRU = ""
                    },

                    new PropertyLayout
                    {
                        Id = 16,
                        NameCZ = "",
                        NameEN = "Other",
                        NameRU = ""
                    }
                };

                context.PropertyLayouts.AddRange(propertyLayouts);
                context.SaveChanges();
            }

            if (!context.OwnershipTypes.Any())
            {
                List<OwnershipType> ownershipTypes = new List<OwnershipType>
                {
                    new OwnershipType
                    {
                        Id = 1,
                        NameCZ = "",
                        NameEN = "Personal",
                        NameRU = ""
                    },

                    new OwnershipType
                    {
                        Id = 2,
                        NameCZ = "",
                        NameEN = "Cooperative",
                        NameRU = ""
                    },

                    new OwnershipType
                    {
                        Id = 3,
                        NameCZ = "",
                        NameEN = "Municipal",
                        NameRU = ""
                    },

                    new OwnershipType
                    {
                        Id = 4,
                        NameCZ = "",
                        NameEN = "Other",
                        NameRU = ""
                    }
                };

                context.OwnershipTypes.AddRange(ownershipTypes);
                context.SaveChanges();
            }

            if (!context.PropertyConditions.Any())
            {
                List<PropertyCondition> propertyConditions = new List<PropertyCondition>
                {
                    new PropertyCondition
                    {
                        Id = 1,
                        NameCZ = "",
                        NameEN = "New build",
                        NameRU = ""
                    },

                    new PropertyCondition
                    {
                        Id = 2,
                        NameCZ = "",
                        NameEN = "Excellent",
                        NameRU = ""
                    },

                    new PropertyCondition
                    {
                        Id = 3,
                        NameCZ = "",
                        NameEN = "Good",
                        NameRU = ""
                    },

                    new PropertyCondition
                    {
                        Id = 4,
                        NameCZ = "",
                        NameEN = "In need of repair",
                        NameRU = ""
                    },

                    new PropertyCondition
                    {
                        Id = 5,
                        NameCZ = "",
                        NameEN = "For demolition",
                        NameRU = ""
                    },

                    new PropertyCondition
                    {
                        Id = 6,
                        NameCZ = "",
                        NameEN = "Development project",
                        NameRU = ""
                    },
                };

                context.PropertyConditions.AddRange(propertyConditions);
                context.SaveChanges();
            }

            if (!context.BuildingTypes.Any())
            {
                List<BuildingType> buildingTypes = new List<BuildingType>
                {
                    new BuildingType
                    {
                        Id = 1,
                        NameCZ = "",
                        NameEN = "Brick building",
                        NameRU = ""
                    },

                    new BuildingType
                    {
                        Id = 2,
                        NameCZ = "",
                        NameEN = "Prefab concrete building",
                        NameRU = ""
                    },

                    new BuildingType
                    {
                        Id = 3,
                        NameCZ = "",
                        NameEN = "Low-energy building",
                        NameRU = ""
                    },

                    new BuildingType
                    {
                        Id = 4,
                        NameCZ = "",
                        NameEN = "Wooden building",
                        NameRU = ""
                    },

                    new BuildingType
                    {
                        Id = 5,
                        NameCZ = "",
                        NameEN = "Development project",
                        NameRU = ""
                    },
                };

                context.BuildingTypes.AddRange(buildingTypes);
                context.SaveChanges();
            }


            if (!context.LandTypes.Any())
            {
                List<LandType> landTypes = new List<LandType>
                {
                    new LandType
                    {
                        Id = 1,
                        NameCZ = "",
                        NameEN = "Residential",
                        NameRU = ""
                    },

                    new LandType
                    {
                        Id = 2,
                        NameCZ = "",
                        NameEN = "Non-residential",
                        NameRU = ""
                    },

                    new LandType
                    {
                        Id = 3,
                        NameCZ = "",
                        NameEN = "Field",
                        NameRU = ""
                    },

                    new LandType
                    {
                        Id = 4,
                        NameCZ = "",
                        NameEN = "Meadow",
                        NameRU = ""
                    },

                    new LandType
                    {
                        Id = 5,
                        NameCZ = "",
                        NameEN = "Wood",
                        NameRU = ""
                    },

                    new LandType
                    {
                        Id = 6,
                        NameCZ = "",
                        NameEN = "Pond",
                        NameRU = ""
                    },

                    new LandType
                    {
                        Id = 7,
                        NameCZ = "",
                        NameEN = "Garden",
                        NameRU = ""
                    },

                    new LandType
                    {
                        Id = 8,
                        NameCZ = "",
                        NameEN = "Other",
                        NameRU = ""
                    }
                };

                context.LandTypes.AddRange(landTypes);
                context.SaveChanges();
            }
        }
    }
}
