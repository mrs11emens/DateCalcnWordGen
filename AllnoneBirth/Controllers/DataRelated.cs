using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AllnoneBirth.Controllers
{
    [ApiController]
    [Route("api/DataCalculator")]
    [Produces("application/json")]
    public class DataController : ControllerBase
    {
        [HttpGet("PassDatainDays")]
        public IActionResult PassfromDatainD(string data)
        {
            if (DateTime.TryParseExact(data, "MM.dd.yyyy", null, System.Globalization.DateTimeStyles.None,
                    out DateTime birthDate))
            {
                var timePassedInDays = (DateTime.Now - birthDate).Days;
                return Ok(new Dictionary<string, int>
                {
                    { "timePassedinDays", timePassedInDays }
                });
            }

            return BadRequest("Некорректный формат даты. Ожидается формат 'MM.dd.yyyy'.");
        }
        [HttpGet("PassDatainWeeks")]
        public IActionResult PassedfromDataW(string data)
        {
            if (DateTime.TryParseExact(data, "MM.dd.yyyy", null, System.Globalization.DateTimeStyles.None,
                    out DateTime birthDate))
            {
                var timePassedInWeeks = (DateTime.Now - birthDate).Days / 7;
                return Ok(new Dictionary<string, int>
                {
                    { "timePassedinWeeks", timePassedInWeeks }
                });
               
            }
            return null;
        }

        [HttpGet("PassDatainMonths")]
        public IActionResult PassedfromDayM(string data)
        {
            if (DateTime.TryParseExact(data, "MM.dd.yyyy", null, System.Globalization.DateTimeStyles.None,
                    out DateTime birthDate))
            {
                var timePassedInMonths = (DateTime.Now - birthDate).Days / 30;
                return Ok(new Dictionary<string, int>
                {
                    { "timePassedinMonths", timePassedInMonths }
                });
            }
            return null;
        }
    }
}