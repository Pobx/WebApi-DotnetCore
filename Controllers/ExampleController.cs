using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApi.Entities;
using WebApi.ResponseDTO;
using WebApi.Utilities;

namespace WebApi.Controllers {
  [ApiController]
  [Route ("api/[controller]")]
  public class ExampleController : ControllerBase {
    readonly SqlConnection _connection;

    public ExampleController (IOptions<ConnectionStrings> connectionString) {
      _connection = new SqlConnection (connectionString.Value.PrimaryDatabaseConnectionString);
    }

    [HttpGet]
    public async Task<ActionResult> Search () {
      var currentPageIndex = 0;
      var PageSize = 10;

      var response = new BaseResponse<IEnumerable<ExampleDemo>> ();
      response.Entities = await _connection.GetAllAsync<ExampleDemo> ();
      response.TotalRows = response.Entities.Count ();
      response.Entities = response.Entities.Skip (currentPageIndex * PageSize).Take (PageSize).ToList ();
      return Ok (response);

    }

    [HttpGet ("{id}")]
    public async Task<ActionResult> Find (int id) {
      var response = new BaseResponse<ExampleDemo> ();
      response.Entities = await _connection.GetAsync<ExampleDemo> (id);
      return Ok (response);
    }

    [HttpPost]
    public async Task<ActionResult> Insert ([FromBody] ExampleDemo criteria) {
      var response = new BaseResponse<ExampleDemo> ();
      await _connection.InsertAsync (criteria);
      response.Entities = criteria;
      return Created ("", response);
    }

    [HttpPut]
    public async Task<ActionResult> Update ([FromBody] ExampleDemo criteria) {
      var response = new BaseResponse<ExampleDemo> ();
      await _connection.UpdateAsync (criteria);
      response.Entities = criteria;
      return Ok (response);
    }
  }
}