namespace Results.Helper.Models;

/// <summary>
/// A Result wrapper class that returns data of type T.
/// </summary>
/// <typeparam name="T">The Type of return data.</typeparam>
public class Result<T>
{
    /// <summary>
    ///The constructor for success results with the return data.
    /// </summary>
    /// <param name="data"></param>
    public Result(T data)
    {
        IsSuccess = true;
        Data = data;
    }

    /// <summary>
    /// The constructor for error results.
    /// </summary>
    /// <param name="errorCode">The Error Code.</param>
    /// <param name="errorMessage">The Error Message.</param>
    /// <param name="errorType">The Error Type.</param>
    public Result(string errorCode, string errorMessage, ErrorType errorType)
    {
        IsSuccess = false;
        Error = new Error(errorCode, errorMessage, errorType);
    }

    /// <summary>
    /// Indicates if the result is successful or an error.
    /// </summary>
    public bool IsSuccess { get; set; }

    /// <summary>
    /// The return data, will be null if the result is an error.
    /// </summary>
    public T? Data { get; set; }

    /// <summary>
    /// The Error object, will be null if the result is successful.
    /// </summary>
    public Error? Error { get; set; }

}

// <summary>
/// A Result wrapper class
/// </summary>
public class Result
{
    /// <summary>
    /// The constructor for success results.
    /// </summary>
    public Result()
    {
        IsSuccess = true;
    }
    
    /// <summary>
    /// The constructor for error results.
    /// </summary>
    /// <param name="errorCode">The Error Code.</param>
    /// <param name="errorMessage">The Error Message.</param>
    /// <param name="errorType">The Error Type.</param>
    public Result(string errorCode, string errorMessage, ErrorType errorType)
    {
        IsSuccess = false;
        Error = new Error(errorCode, errorMessage, errorType);
    }

    /// <summary>
    /// Indicates if the result is successful or an error.
    /// </summary>
    public bool IsSuccess { get; set; }

    /// <summary>
    /// The Error object, will be null if the result is successful.
    /// </summary>
    public Error? Error { get; set; }
}