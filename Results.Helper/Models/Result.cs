namespace Results.Helper.Models;

public class Result<T>
{
    public Result(T data)
    {
        IsSuccess = true;
        Data = data;
    }

    public Result(string errorCode, string errorMessage, ErrorType errorType)
    {
        IsSuccess = false;
        Error = new Error(errorCode, errorMessage, errorType);
    }
    
    public bool IsSuccess { get; set; }
    public T? Data { get; set; }
    public Error? Error { get; set; }
    
}

public class Result
{
    public Result()
    {
        IsSuccess = true;
    }
    
    public Result(string errorCode, string errorMessage, ErrorType errorType)
    {
        IsSuccess = false;
        Error = new Error(errorCode, errorMessage, errorType);
    }
    
    public bool IsSuccess { get; set; }
    
    public Error? Error { get; set; }
}