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
    [Route ("Search")]
    public async Task<ActionResult> Search () {
      return Ok ("Search !");
    }

    [HttpPost]
    [Route ("Insert")]
    public async Task<ActionResult> Insert () {
      return Ok ("Insert !");
    }

    [HttpPut]
    [Route ("Update")]
    public async Task<ActionResult> Update () {
      return Ok ("Update !");
    }
  }
}