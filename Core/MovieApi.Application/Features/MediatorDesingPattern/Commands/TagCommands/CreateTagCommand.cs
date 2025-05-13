﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace MovieApi.Application.Features.MediatorDesingPattern.Commands.TagCommands
{
    public class CreateTagCommand : IRequest
    {
        public string Title { get; set; }
    }
}
