using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApi.Utilities;

namespace WebApi.Controllers {
  [ApiController]
  [Route ("api/[controller]")]
  public class ExampleController : ControllerBase {
    private readonly SqlConnection _connection;
    public ExampleController (IOptions<ConnectionStrings> connectionString) {
      _connection = new SqlConnection (connectionString.Value.PrimaryDatabaseConnectionString);
      Console.WriteLine($"connectionString ===========> {connectionString.Value.PrimaryDatabaseConnectionString}");
    }

    [HttpGet]
    public async Task<ActionResult> Search () {
      await Task.CompletedTask;
      return Ok ("Search !");
    }

    [HttpGet ("{id}")]
    public async Task<ActionResult> Find (int id) {
      await Task.CompletedTask;
      return Ok ("Search !");
    }

    [HttpPost]
    public async Task<ActionResult> Insert () {
      await Task.CompletedTask;
      return Created ("", "Insert !");
    }

    [HttpPut]
    public async Task<ActionResult> Update () {
      await Task.CompletedTask;
      return Ok ("Update !");
    }
  }
}