using MediatR;

namespace Message.API.Dtos;

/// <summary>
/// Message creation request.
/// </summary>
public class CreateMessageRequest
    : IRequest<CreateMessageResponse>
{
    /// <summary>
    /// Gets or sets Message.
    /// </summary>
    public string Message { get; set; } = null!;
}
