using MediatR;
using Message.API.Dtos;

namespace Message.API.Domain;

public class MessageDomain : IRequestHandler<CreateMessageRequest, CreateMessageResponse>
{
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

    public CreateMessageResponse ValidateMessage(CreateMessageRequest createMessageRequest)
    {
        if (createMessageRequest.Message.Length < 1)
            return new CreateMessageResponse(false, "Message is required");

        if (createMessageRequest.Message.Length > 20)
            return new CreateMessageResponse(false, "Message is too long");

        return new CreateMessageResponse(true);
    }
}
