using MediatR;
using Message.API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Message.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MessageController : ControllerBase
{
    private readonly IMediator _mediator;

    public MessageController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<CreateMessageResponse> CreateMessage(CreateMessageRequest createMessageRequest)
    {
        return await _mediator.Send(createMessageRequest);
    }
}
