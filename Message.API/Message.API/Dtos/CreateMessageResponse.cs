using MediatR;

namespace Message.API.Dtos
{
    public class CreateMessageResponse(bool success, string errorMessage = null!) 
    {
        public bool Success { get; set; } = success;
        public string Message { get; set; } = errorMessage;
    }
}
