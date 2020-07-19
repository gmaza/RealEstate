using MediatR;

namespace Application.Listings.Queries.GetListingsForLP
{
    public class GetListingsForLPQuery : IRequest<ListingsForLPVM>
    {
        public int? Page { get; set; }
        public int? PageSize { get; set; }
    }
}
