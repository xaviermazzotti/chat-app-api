using MediatR;
using Message.API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Message.API.Controllers;

/// <summary>
/// Initializes a new instance of the <see cref="MessageController"/> class.
/// </summary>
/// <param name="mediator">Mediator interface.</param>
[ApiController]
[Route("api/[controller]")]
public class MessageController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    /// <summary>
    /// Create message endpoint.
    /// </summary>
    /// <param name="createMessageRequest">Message creation request.</param>
    /// <returns>Message creation response.</returns>
    [HttpPost]
    public async Task<CreateMessageResponse> CreateMessage(CreateMessageRequest createMessageRequest)
    {
        return await _mediator.Send(createMessageRequest);
    }
}
