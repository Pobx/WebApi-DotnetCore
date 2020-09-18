using System;
using Dapper.Contrib.Extensions;

namespace WebApi.Entities {

  [Table ("ExampleDemo")]
  public class ExampleDemo : IEntities {
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
    public string IsActive { get; set; } = "Y";
    [Computed]
    public string CreatedBy { get; set; } = "Pobx";
    [Computed]
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public string UpdatedBy { get; set; } = "Pobx";
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
  }
}