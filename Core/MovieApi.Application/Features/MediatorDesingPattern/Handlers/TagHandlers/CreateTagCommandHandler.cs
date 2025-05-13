using MediatR;
using MovieApi.Application.Features.MediatorDesingPattern.Commands.TagCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesingPattern.Handlers.TagHandlers
{
    internal class CreateTagCommandHandler : IRequestHandler<CreateTagCommand>
    {
        private readonly MovieContext _movieContext;

        public CreateTagCommandHandler(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            await _movieContext.Tags.AddAsync(new Tag
            {
                Title = request.Title
            });
            await _movieContext.SaveChangesAsync();
        }
    }
}
