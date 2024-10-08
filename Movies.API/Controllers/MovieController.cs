using MediatR;
using Microsoft.AspNetCore.Mvc;
using Movies.Application.Mappers;
using Movies.Application.Commands;
using Movies.Application.Queries;
using Movies.Application.Responses;

namespace Movies.API.Controllers;

public class MovieController : ApiController
{
    private readonly IMediator _mediator;

    public MovieController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<MovieResponse>>> GetMoviesByDirectorName(string directorName)
    {
        var query = MovieMapper.Mapper.Map<GetMoviesByDirectorNameQuery>(directorName);
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<MovieResponse>> CreateMovie([FromBody] CreateMovieCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}
