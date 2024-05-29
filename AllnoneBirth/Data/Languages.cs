using System;

namespace AllnoneBirth.Data
{
    public static class Languages
    {
        private static readonly Random _random = new Random();

        // Латиница
        private static readonly string englishVowels = "aeiou";
        private static readonly string englishConsonants = "bcdfghjklmnpqrstvwxyz";

        // Кириллица
        private static readonly string russianVowels = "аеёиоуыэюя";
        private static readonly string russianConsonants = "бвгджзйклмнпрстфхцчшщ";

        // Японский
        private static readonly string japaneseVowels = "あいうえお";
        private static readonly string japaneseConsonants = "かきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやゆよらりるれろわをん";

        // Арабский
        private static readonly string arabicVowels = "اىو";
        private static readonly string arabicConsonants = "بتثجحخدذرزسشصضطظعغفقكلمنه";

        public static char GetRandomEnglishVowel()
        {
            return englishVowels[_random.Next(englishVowels.Length)];
        }

        public static char GetRandomEnglishConsonant()
        {
            return englishConsonants[_random.Next(englishConsonants.Length)];
        }

        public static char GetRandomRussianVowel()
        {
            return russianVowels[_random.Next(russianVowels.Length)];
        }

        public static char GetRandomRussianConsonant()
        {
            return russianConsonants[_random.Next(russianConsonants.Length)];
        }

        public static char GetRandomJapaneseVowel()
        {
            return japaneseVowels[_random.Next(japaneseVowels.Length)];
        }

        public static char GetRandomJapaneseConsonant()
        {
            return japaneseConsonants[_random.Next(japaneseConsonants.Length)];
        }

        public static char GetRandomArabicVowel()
        {
            return arabicVowels[_random.Next(arabicVowels.Length)];
        }

        public static char GetRandomArabicConsonant()
        {
            return arabicConsonants[_random.Next(arabicConsonants.Length)];
        }
    }
}
