using System;
namespace WebApi.ResponseDTO {
  public class BaseResponse {
    public T Entities { get; set; }
    public DateTime CurrentDateTime { get; } = DateTime.UtcNow;
    public List<string> ErrorMessages { get; set; } = new List<string> ();
    public int TotalRows { get; set; } = 0;
    public int TotalPages { get; set; } = 0;

  }
}