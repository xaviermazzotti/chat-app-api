namespace Message.API.Dtos;

public class CreateMessageResponse(bool success, string errorMessage = null!)
{
    /// <summary>
    /// Gets or sets Success.
    /// </summary>
    public bool Success { get; set; } = success;

    /// <summary>
    /// Gets or sets Message.
    /// </summary>
    public string Message { get; set; } = errorMessage;
}
