//ЗАДАНИЕ1-------------------------------------------------------------------------------------------------------

List<string> strings = new List<string> { "123", "2D4", "456", "ABC" };
List<string> onlyDigits = strings.Where(s => s.All(char.IsDigit)).ToList();

//ЗАДАНИЕ2-------------------------------------------------------------------------------------------------------

List<int> numbers = new List<int> { -2, 4, -6, 8, 10, -12 };
int max = numbers.Where(n => n > 0).Max();
int min = numbers.Where(n => n > 0).Min();

//ЗАДАНИЕ3------------------------------------------------------------------------------------------------------- 

List<string> words = new List<string> { "apple", "banana", "apple", "orange", "banana", "apple" };
string mostFrequentWord = words.SelectMany(w => w.Split(' ')).GroupBy(w => w).OrderByDescending(g => g.Count()).First().Key;

//ЗАДАНИЕ4-------------------------------------------------------------------------------------------------------

List<string> stringss = new List<string> { "abc", "xyz", "defg", "hijk", "lmn", "opqrs" };
List<string> sortedStrings = strings.OrderByDescending(s => s.Length).ThenBy(s => s).ToList();

//ЗАДАНИЕ5-------------------------------------------------------------------------------------------------------

List<DateTime> dates = new List<DateTime> { new DateTime(2022, 1, 1), new DateTime(2022, 3, 15), new DateTime(2022, 2, 10) };
int dayDifference = dates.Max().Subtract(dates.Min()).Days;