﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesingPattern.Commands.MovieCommands
{
    public class RemoveMovieCommand
    {
        public int MovieId { get; set; }
    }
}
