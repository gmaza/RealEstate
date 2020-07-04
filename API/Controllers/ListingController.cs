using Application.Listings.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ListingController : ApiController
    {
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<long>> CreateListing(CreateListingCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
