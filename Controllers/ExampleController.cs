﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers {
  [ApiController]
  [Route ("[controller]")]
  public class ExampleController : ControllerBase {

    public ExampleController () {

    }

    [HttpGet]
    public void Get () { }
  }
}