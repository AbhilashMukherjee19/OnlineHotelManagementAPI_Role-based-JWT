﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementAPI.Models;
using OnlineHotelManagementAPI.Service;

namespace OnlineHotelManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {
        private readonly RateService S_rate;

        public RateController(RateService rate)
        {
            S_rate = rate;
        }

        [HttpPost("InsertRate"), Authorize(Roles = "Manager")]
        public IActionResult InsertRate(Rate rate)
        {
            return Ok(S_rate.InsertRate(rate));
        }

        [HttpPut("UpdateRate"), Authorize(Roles = "Manager")]
        public IActionResult UpdateRate(Rate rate)
        {
            return Ok(S_rate.UpdateRate(rate));
        }

        [HttpGet("GetAllRate"), Authorize(Roles = "Manager")]
        public IActionResult GetAllRate()
        {
            return Ok(S_rate.GetAllRate());
        }
    }
}
