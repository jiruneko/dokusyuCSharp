using System.Globalization;

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Today);

var dt3 = "Dienstag, 15.Februar 2022 13:17:23";
Console.WriteLine(DateTime.Parse(dt3, new CultureInfo("de-DE")));

var dt = new DateTime(2022, 02, 15, 13, 17, 23);
var cal = new CultureInfo("ja-JP");
cal.DateTimeFormat.Calendar = new JapaneseCalendar();
Console.WriteLine(dt.ToString("ggyy年MM月dd日（ddd）tthh:mm:ss", cal));

var dt2 = new DateTime(2022, 02, 15, 13, 17, 23);
var span = new TimeSpan(3, 15, 30, 0);
Console.WriteLine(dt2.Add(span));