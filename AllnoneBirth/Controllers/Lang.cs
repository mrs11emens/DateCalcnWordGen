using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Concurrent;
using System.Text;
using AllnoneBirth.Data;
using AllnoneBirth.JsonProperties;

namespace AllnoneBirth.Controllers
{
    [ApiController]
    [Route("api/BirthDay")]
    [Produces("application/json")]
    public class LangController : ControllerBase
    {
        private static readonly ConcurrentDictionary<string, DateTime> _dict = new ConcurrentDictionary<string, DateTime>();

        [HttpPost("GenerateWordsLatin")]
        public IActionResult GenerateWordsLatin([FromBody] ChooseLang request)
        {
            if (request.SymbolAmount <= 0)
            {
                return BadRequest(new { error = "Symbol amount must be a positive integer." });
            }

            StringBuilder generatedWord = new StringBuilder();
            for (int i = 0; i < request.SymbolAmount; i++)
            {
                generatedWord.Append(i % 2 == 0 ? Languages.GetRandomEnglishConsonant() : Languages.GetRandomEnglishVowel());
            }

            string langString = generatedWord.ToString();
            var now = DateTime.Now;

            _dict[langString] = now;

            return Ok(new
            {
                generatedWord = langString,
                timestamp = now.ToString("yyyy-MM-dd HH:mm:ss")
            });
        }

        [HttpPost("GenerateWordsCyrillic")]
        public IActionResult GenerateWordsCyrillic([FromBody] ChooseLang request)
        {
            if (request.SymbolAmount <= 0)
            {
                return BadRequest(new { error = "Symbol amount must be a positive integer." });
            }

            StringBuilder generatedWord = new StringBuilder();
            for (int i = 0; i < request.SymbolAmount; i++)
            {
                generatedWord.Append(i % 2 == 0 ? Languages.GetRandomRussianConsonant() : Languages.GetRandomRussianVowel());
            }

            string langString = generatedWord.ToString();
            var now = DateTime.Now;

            _dict[langString] = now;

            return Ok(new
            {
                generatedWord = langString,
                timestamp = now.ToString("yyyy-MM-dd HH:mm:ss")
            });
        }

        [HttpPost("GenerateWordsJapanese")]
        public IActionResult GenerateWordsJapanese([FromBody] ChooseLang request)
        {
            if (request.SymbolAmount <= 0)
            {
                return BadRequest(new { error = "Symbol amount must be a positive integer." });
            }

            StringBuilder generatedWord = new StringBuilder();
            for (int i = 0; i < request.SymbolAmount; i++)
            {
                generatedWord.Append(i % 2 == 0 ? Languages.GetRandomJapaneseConsonant() : Languages.GetRandomJapaneseVowel());
            }

            string langString = generatedWord.ToString();
            var now = DateTime.Now;

            _dict[langString] = now;

            return Ok(new
            {
                generatedWord = langString,
                timestamp = now.ToString("yyyy-MM-dd HH:mm:ss")
            });
        }

        [HttpPost("GenerateWordsArabic")]
        public IActionResult GenerateWordsArabic([FromBody] ChooseLang request)
        {
            if (request.SymbolAmount <= 0)
            {
                return BadRequest(new { error = "Symbol amount must be a positive integer." });
            }

            StringBuilder generatedWord = new StringBuilder();
            for (int i = 0; i < request.SymbolAmount; i++)
            {
                generatedWord.Append(i % 2 == 0 ? Languages.GetRandomArabicConsonant() : Languages.GetRandomArabicVowel());
            }

            string langString = generatedWord.ToString();
            var now = DateTime.Now;

            _dict[langString] = now;

            return Ok(new
            {
                generatedWord = langString,
                timestamp = now.ToString("yyyy-MM-dd HH:mm:ss")
            });
        }

        [HttpGet("GetLanguage")]
        public IActionResult GetLanguage()
        {
            var allWords = new StringBuilder();
            foreach (var word in _dict.Keys)
            {
                allWords.Append(word + " ");
            }

            var wordsArray = allWords.ToString().Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return Ok(new
            {
                words = wordsArray,
                timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            });
        }
    }
}
