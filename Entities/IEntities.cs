using System;
namespace WebApi.Entities {
  public interface IEntities {
    public string IsActive { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
  }
}