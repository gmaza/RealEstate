using Application.Favorites.Commands.AddFavorite;
using Application.Favorites.Commands.DeleteFavorite;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize]
    public class FavoriteController : ApiController
    {

        [HttpPost("{id}")]
        public async Task<ActionResult> AddFavorite(long id)
        {
            await Mediator.Send(new AddFavoriteCommand { Id = id });

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFavorite(long id)
        {
            await Mediator.Send(new DeleteFavoriteCommand { Id = id });

            return NoContent();
        }
    }
}
