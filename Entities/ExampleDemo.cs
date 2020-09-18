using System;
namespace WebApi.Entities {
  public class ExampleDemo : IEntities {
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string IsActive { get; set; } = "Y";
    public string CreatedBy { get; set; } = "Pobx";
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public string UpdatedBy { get; set; } = "Pobx";
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
  }
}