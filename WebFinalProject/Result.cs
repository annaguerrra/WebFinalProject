
using WebFinalProject.UseCases.Plans.ListAvaliablePlans;

public record Result<T>(
    T Data,
    bool IsSuccess,
    string Reason
)
{
    public static Result<T> Ok(T data)
        => new(data, true, null);

    public static Result<T> BadRequest(string reason)
        => new(default, false, reason);
}
