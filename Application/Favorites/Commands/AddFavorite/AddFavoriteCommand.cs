using MediatR;

namespace Application.Favorites.Commands.AddFavorite
{
    public class AddFavoriteCommand : IRequest
    {
        public long Id { get; set; }
    }
}
