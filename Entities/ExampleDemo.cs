using System;
using Dapper.Contrib.Extensions;

namespace WebApi.Entities {

  [Table ("ExampleDemo")]
  public class ExampleDemo : IEntities {
    [Key]
    public int Id { get; set; } = 0;

    public string Name { get; set; }
    public string IsActive { get; set; } = "Y";
    public string CreatedBy { get; set; } = "Pobx";
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public string UpdatedBy { get; set; } = "Pobx";
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
  }
}