using MediatR;
using Message.API.Dtos;

namespace Message.API.Domain;

public class MessageDomain : IRequestHandler<CreateMessageRequest, CreateMessageResponse>
{
    /// <summary>
    /// Creates a message in the database or return error if validation fails.
    /// </summary>
    /// <param name="request">Message creation request.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Message creation response.</returns>
    public Task<CreateMessageResponse> Handle(CreateMessageRequest request, CancellationToken cancellationToken)
    {
        var result = ValidateMessage(request);

        if (!result.Success)
            return Task.FromResult(result);

        Console.WriteLine("Saving message...");
        result.Message = "Message create successfully";

        // Simulate database update
        Thread.Sleep(1);

        return Task.FromResult(result);
    }

    /// <summary>
    /// Validates a message.
    /// </summary>
    /// <param name="createMessageRequest">Message creation request.</param>
    /// <returns>Message validation response.</returns>
    public CreateMessageResponse ValidateMessage(CreateMessageRequest createMessageRequest)
    {
        if (string.IsNullOrEmpty(createMessageRequest?.Message) || createMessageRequest.Message.Length < 1)
            return new CreateMessageResponse(false, "Message is required");

        if (createMessageRequest.Message.Length > 20)
            return new CreateMessageResponse(false, "Message is too long");

        return new CreateMessageResponse(true);
    }
}
