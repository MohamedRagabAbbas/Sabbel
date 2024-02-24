namespace SabeelAPI.DTO.Response
{
  public class ServerResponse<T>
  {
    public string Message { get; set; } = string.Empty;
    public bool IsSuccess { get; set; } = false;
    public T? Data { get; set; } = default;
  }
}
