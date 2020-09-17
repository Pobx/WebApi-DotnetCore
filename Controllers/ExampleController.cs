using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers {
  [ApiController]
  [Route ("api/[controller]")]
  public class ExampleController : ControllerBase {
    private readonly SqlConnection _connection;
    public ExampleController (IOptions<ConnectionStrings> connectionString) {
      _connection = new SqlConnection (connectionString.Value.PrimaryDatabaseConnectionString);
    }

    [HttpGet]
    [Route]
    public async Task<ActionResult> Search () {
      return Ok ("Search !");
    }

    [HttpGet ("{id}")]
    public async Task<ActionResult> Find () {
      return Ok ("Search !");
    }

    [HttpPost]
    public async Task<ActionResult> Insert () {
      return Create ("", "Insert !");
    }

    [HttpPut]
    public async Task<ActionResult> Update () {
      return Ok ("Update !");
    }
  }
}