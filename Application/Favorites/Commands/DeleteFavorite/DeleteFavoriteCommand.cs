using MediatR;

namespace Application.Favorites.Commands.DeleteFavorite
{
    public class DeleteFavoriteCommand : IRequest
    {
        public long Id { get; set; }
    }
}
