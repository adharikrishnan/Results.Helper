using System.Net;
using Results.Helper.Models;

namespace Results.Helper.Extensions;

public static class ApiResultExtensions
{
    /// <summary>
    /// Maps the ErrorType to the corresponding HttpStatusCode.
    /// </summary>
    /// <param name="error">The Error Object</param>
    /// <returns>The HttpStatusCode.</returns>
    public static HttpStatusCode GetStatusCode(this Error error) =>
        error.ErrorType switch
        {
            ErrorType.NotFound => HttpStatusCode.NotFound,
            ErrorType.Validation => HttpStatusCode.BadRequest,
            ErrorType.Conflict => HttpStatusCode.Conflict,
            ErrorType.Unauthorized => HttpStatusCode.Unauthorized,
            _ => HttpStatusCode.InternalServerError,
        };
}