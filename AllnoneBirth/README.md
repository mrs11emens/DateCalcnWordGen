# DateCalc

## DateRelated.cs/DateController

В этом контроллере есть несколько ендпоинтов, проводящих
расчеты от сегодняшней даты до введенной даты.

Первый ендпоинт рассчитывает и затем показывает результат
в днях. Пример:

Request body
```json
{
  "date": "01.01.2000"
}
```
Скажу, что в будущих ендпоинтах связанных с датой это значение не изменится, и дабы не повторяться я буду писать просто Request body

Response body
```json
{
  "timePassedinDays": 8915
}
```

Второй ендпоинт похож, но только возвращает результат 
в неделях.

Пример:

Request body 

Response body

```json
{
  "timePassedinWeeks": 1273
}
```

Ну и третий, он возвращает уже в месяцах.

Пример:

Request body

Response body
```json
{
  "timePassedinMonths": 297
}
```
Главное, чтобы дата вводилась в формате "dd.MM.yyyy", где dd - дни, ММ - месяцы, ну и четыре игрека это годы.

--- 
# Word generating

## Lang.cs/LangController

Переходим к генерации слов. Методы все похожи, поэтому
опишу один. В ендпоинте GenerateWordsLatin мы генерируем слово, используя гласные и согласные
из латинского алфавита(в коде описан как английский). Пример запроса:

Request body
```json
{
  "symbolAmount": 5
}
```

Response body
```json
{
  "generatedWord": "gihov",
  "timestamp": "2024-05-29 10:21:02"
}
```

С остальными ендпоинтами где генерация с кириллицей, иероглифами и тд принцип одинаковый и ответ тоже. Меняются только алфавиты и слова

Есть ендпоинт GetLanguage, выводит все ваши сгенерированные слова. Пример:

Response body
```json
{
  "words": [
    "в",
    "чегёжышодазё",
    "р",
    "м",
    "gihov",
    "ц",
    "щ"
  ],
  "timestamp": "2024-05-29 10:24:26"
}
```




