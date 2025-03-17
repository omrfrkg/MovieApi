using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MovieApi.Application.Features.MediatorDesingPattern.Queries.CastQueries;
using MovieApi.Application.Features.MediatorDesingPattern.Results.CastResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesingPattern.Handlers.CastHandlers
{
    public class GetCastByIdQueryHandler : IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResult>
    {
        private readonly MovieContext _context;
        public async Task<GetCastByIdQueryResult> IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResult>.Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Casts.FindAsync(request.CastId);
            return new GetCastByIdQueryResult
            {
                Biography = value.Biography,
                CastId = value.CastId,
                ImageUrl = value.ImageUrl,
                Name = value.Name,
                Overview = value.Overview,
                Surname = value.Surname,
                Title = value.Title,
            };
        }
    }

}
