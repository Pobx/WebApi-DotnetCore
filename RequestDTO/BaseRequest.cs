using System;
using System.Collections.Generic;

namespace WebApi.RequestDTO {
  public class BaseRequest {
    public DateTime CurrentDateTime { get; } = DateTime.UtcNow;
    public List<string> ErrorMessages { get; set; } = new List<string> ();
    public int PageNumber { get; set; } = 0;
    public int PageSize { get; set; } = 10;

  }
}