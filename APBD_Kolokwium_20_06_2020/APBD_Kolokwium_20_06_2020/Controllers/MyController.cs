using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD_Kolokwium_20_06_2020.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Kolokwium_20_06_2020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly IDbService _dbService;

        // INICJUJ DBService
        public MyController(IDbService service)
        {
            _dbService = service;
        }

        [HttpGet("{IdMistrzostwa}")]
        public IActionResult GetTeams(string IdMistrzostwa)
        {
            
            return Ok(_dbService.GetTeams());
        }

    }
}