using MediatR;
using MovieApi.Application.Features.MediatorDesingPattern.Results.TagResults;

namespace MovieApi.Application.Features.MediatorDesingPattern.Queries.TagQueries
{
    public class GetTagByIdQuery : IRequest<GetTagByIdQueryResult>
    {
        public int TagId { get; set; }

        public GetTagByIdQuery(int tagId)
        {
            TagId = tagId;
        }
    }
}
