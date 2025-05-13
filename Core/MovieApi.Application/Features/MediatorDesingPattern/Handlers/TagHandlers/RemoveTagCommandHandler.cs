using MediatR;
using MovieApi.Application.Features.MediatorDesingPattern.Commands.TagCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesingPattern.Handlers.TagHandlers
{
    internal class RemoveTagCommandHandler : IRequestHandler<RemoveTagCommand>
    {
        private readonly MovieContext _movieContext;

        public RemoveTagCommandHandler(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task Handle(RemoveTagCommand request, CancellationToken cancellationToken)
        {
            var values = await _movieContext.Tags.FindAsync(request.TagId);
            _movieContext.Tags.Remove(values);
            await _movieContext.SaveChangesAsync();
        }
    }
}
