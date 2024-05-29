using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Annotations;
using AllnoneBirth.JsonProperties;

namespace AllnoneBirth.Controllers
{
    [ApiController]
    [Route("api/DateCalculator")]
    [Produces("application/json")]
    public class DateController : ControllerBase
    {
        [HttpPost("PassDatainDays")]
        public IActionResult PassfromDatainD([FromBody] DateJSON dateJson)
        {
            if (DateTime.TryParseExact(dateJson.Date, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None,
                    out DateTime Date))
            {
                var timePassedInDays = (DateTime.Now - Date).Days;
                return Ok(new Dictionary<string, int>
                {
                    { "timePassedinDays", timePassedInDays }
                });
            }

            return BadRequest("Некорректный формат даты. Ожидается формат 'dd.MM.yyyy'.");
        }
        [HttpPost("PassDatainWeeks")]
        public IActionResult PassedfromDataW([FromBody] DateJSON dateJson)
        {
            if (DateTime.TryParseExact(dateJson.Date, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None,
                    out DateTime Date))
            {
                var timePassedInWeeks = (DateTime.Now - Date).Days / 7;
                return Ok(new Dictionary<string, int>
                {
                    { "timePassedinWeeks", timePassedInWeeks }
                });
               
            }
            return BadRequest("Некорректный формат даты. Ожидается формат 'dd.MM.yyyy'.");
        }

        [HttpPost("PassDatainMonths")]
        public IActionResult PassedfromDayM([FromBody] DateJSON dateJson)
        {
            if (DateTime.TryParseExact(dateJson.Date, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None,
                    out DateTime Date))
            {
                var timePassedInMonths = (DateTime.Now - Date).Days / 30;
                return Ok(new Dictionary<string, int>
                {
                    { "timePassedinMonths", timePassedInMonths }
                });
            }
            return BadRequest("Некорректный формат даты. Ожидается формат 'dd.MM.yyyy'.");
        }
    }
}