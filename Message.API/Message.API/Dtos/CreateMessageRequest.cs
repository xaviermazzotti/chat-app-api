using MediatR;

namespace Message.API.Dtos;

public class CreateMessageRequest
    : IRequest<CreateMessageResponse>
{
    public string Message { get; set; } = null!;
}
