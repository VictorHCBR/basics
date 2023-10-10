//var t1 = TimeSpan.MaxValue;
//var t2 = TimeSpan.MinValue;
//var t3 = TimeSpan.Zero;

#region overflow
//returns an exception, cuz the value is too long and cannot
//be properly stored

//var range = t1 - t2;
//var total = t3 - t2;
#endregion

DateTime today = DateTime.Now;
DateTime dayOfBirth = new(1992, 12, 15);
var diff = today - dayOfBirth;

//var myDate = new
//{
//    year = today.Year - dayOfBirth.Year,
//    month = today.Month - dayOfBirth.Month,
//    day = today.Day - dayOfBirth.Day,
//};

//Console.WriteLine(myDate.year);
//Console.WriteLine(myDate.month);
//Console.WriteLine(myDate.day);

//Console.WriteLine(t1.Days);
//Console.WriteLine(t2.Days);
//Console.WriteLine(t3.TotalSeconds);

//int year = diff.Days / 365;
//int month = diff.Days % 12;
//int day = (diff.Days % 365) / 12;

var total = today.Subtract(dayOfBirth);


//Console.WriteLine($"Se passaram {year} anos, {month} meses e {day} dias desde que nasci");

Console.WriteLine(total);