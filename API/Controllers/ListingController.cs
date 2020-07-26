using API.Helpers;
using Application.Listings.Commands.CreateListing;
using Application.Listings.Commands.DeleteListing;
using Application.Listings.Commands.UpdateListing;
using Application.Listings.Queries.GetListingDetails;
using Application.Listings.Queries.GetListingFormData;
using Application.Listings.Queries.GetListingsForLP;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ListingController : ApiController
    {
        private Cloudinary _cloudinary;
        public ListingController(IOptions<CloudinarySettings> cloudinaryConfig)
        {
            Account acc = new Account(
                cloudinaryConfig.Value.CloudName,
                cloudinaryConfig.Value.ApiKey,
                cloudinaryConfig.Value.ApiSecret
            );

            _cloudinary = new Cloudinary(acc);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ListingDetailsDto>> Get(long id)
        {
            return await Mediator.Send(new GetListingDetailsQuery { Id = id });
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<long>> Create([FromForm] CreateListingCommand command, List<IFormFile> imageFiles)
        {
            List<ImageUploadResult> uploadResults = new List<ImageUploadResult>();
            foreach (var file in imageFiles)
            {
                using (var stream = file.OpenReadStream())
                {
                    var uploadParams = new ImageUploadParams
                    {
                        File = new FileDescription(file.Name, stream),
                    };

                    uploadResults.Add(_cloudinary.Upload(uploadParams));
                }
            }

            command.ImageUrls = uploadResults.Select(x => x.Url.ToString()).ToList();

            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult> Update(long id, UpdateListingCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await Mediator.Send(command);

            return NoContent();
        }


        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult> Delete(long id)
        {
            await Mediator.Send(new DeleteListingCommand { Id = id });

            return NoContent();
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ListingsForLPVM>> GetListingsForLP(int? page = null, int? pageSize = null)
        {
            return await Mediator.Send(new GetListingsForLPQuery { Page = page, PageSize = pageSize });
        }


        [HttpGet("[action]")]
        public async Task<ActionResult<ListingFormDataVM>> GetListingFormData(long? id)
        {
            return await Mediator.Send(new GetListingFormDataQuery { Id = id });
        }
		
		[HttpGet("[action]")]
        public async Task<ActionResult<ListingFieldOptionsDto>> GetListingFieldOptions()
        {
            return await Mediator.Send(new GetListingFieldOptionsQuery());
        }
    }
}
