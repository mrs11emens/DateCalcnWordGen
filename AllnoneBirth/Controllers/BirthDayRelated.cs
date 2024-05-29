using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AllnoneBirth.Controllers
{
    [ApiController]
    [Route("api/BirthDay")]
    [Produces("application/json")]
    public class BdayController : ControllerBase
    {
        [HttpGet("BirthinDays")]
        public IActionResult PassfromBirthinD(string bday)
        {
            if (DateTime.TryParseExact(bday, "MM.dd.yyyy", null, System.Globalization.DateTimeStyles.None,
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
        [HttpGet("BirthinWeeks")]
        public IActionResult PassedfromBirthW(string bday)
        {
            if (DateTime.TryParseExact(bday, "MM.dd.yyyy", null, System.Globalization.DateTimeStyles.None,
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

        [HttpGet("BirthinMonths")]
        public IActionResult PassedfromBirthM(string bday)
        {
            if (DateTime.TryParseExact(bday, "MM.dd.yyyy", null, System.Globalization.DateTimeStyles.None,
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