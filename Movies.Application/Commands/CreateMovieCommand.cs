﻿using MediatR;
using Movies.Application.Responses;

namespace Movies.Application;

public class CreateMovieCommand: IRequest<MovieResponse>
{
    public string MovieName { get; set; }
    public string DirectorName { get; set;}
    public string ReleaseYear { get; set;}
}
