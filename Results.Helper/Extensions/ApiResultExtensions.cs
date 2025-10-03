using System.Net;
using Results.Helper.Models;

namespace Results.Helper.Extensions;

public static class ApiResultExtensions
{
    public static HttpStatusCode GetStatusCode(this Error error) =>
        error.ErrorType switch
        {
            ErrorType.NotFound => HttpStatusCode.NotFound,
            ErrorType.Validation => HttpStatusCode.BadRequest,
            ErrorType.Conflict => HttpStatusCode.Conflict,
            ErrorType.Unauthorized => HttpStatusCode.Unauthorized,
            _ => HttpStatusCode.InternalServerError,
        };

    public static string GetDetail(this Error error) =>
        error.ErrorMessage ?? "An Unexpected error occured please contact support.";
    
    public static string GetTitle(this Error error) =>
        error.ErrorCode ?? "UNEXPECTED_ERROR";
}