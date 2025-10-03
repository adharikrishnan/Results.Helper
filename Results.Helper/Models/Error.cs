namespace Results.Helper.Models;

/// <summary>
/// Class for Error details
/// </summary>
/// <param name="errorCode">The custom error code.</param>
/// <param name="errorMessage">The error message.</param>
/// <param name="errorType">The error type.</param>
public class Error(string errorCode, string errorMessage, ErrorType errorType)
{
    /// <summary>
    /// The custom error code string.
    /// </summary>
    public string? ErrorCode { get; set; } = errorCode;

    /// <summary>
    /// The error message string.
    /// </summary>
    public string? ErrorMessage { get; set; } = errorMessage;

    /// <summary>
    /// The Error Type enum.
    /// </summary>
    public ErrorType ErrorType { get; set; } = errorType;
}

public enum ErrorType
{
    Validation,
    NotFound,
    Conflict,
    Unauthorized,
    InternalError,
}