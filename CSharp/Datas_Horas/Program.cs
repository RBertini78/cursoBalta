using System.Globalization;

namespace Datas_Horas;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(DateTime.DaysInMonth(2025, 2));
        Console.WriteLine(DateTime.IsLeapYear(2025));
        Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
        Console.WriteLine(DateTime.Now.DayOfYear);

        static bool IsweekEnd(DayOfWeek day)
        {
            return day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;
        }

        Console.WriteLine(IsweekEnd(DateTime.Now.DayOfWeek));

        Console.WriteLine(DateTime.Now);

        var data = DateTime.Now;
        var fortmatada = String.Format("{0:dd-MMMM-yyyy hh:mm:ss zzz}", data);
        Console.WriteLine(fortmatada);
        var fortmatada2 = String.Format("{0:D}" + " {0:T}", data); // D = data, T = hora
        Console.WriteLine(fortmatada2);
        var fortmatada3 = String.Format("{0:F}", data); // F = data e hora
        Console.WriteLine(fortmatada3);
        var fortmatada4 = String.Format("{0:R}", data); // R = data e hora UTC
        Console.WriteLine(fortmatada4);
        var fortmatada5 = String.Format("{0:s}", data); //Usado para salvar em banco de dados (MongoDB)
        Console.WriteLine(fortmatada5);

        Console.WriteLine(data.AddDays(12));
        Console.WriteLine(data.AddMonths(2));
        Console.WriteLine(data.AddYears(3));

        var en = new CultureInfo("en-US");
        var de = new CultureInfo("de-DE");
        var es = new CultureInfo("es-ES");

        Console.WriteLine(data.ToString("D", en));
        Console.WriteLine(data.ToString("D", de));
        Console.WriteLine(data.ToString("D", es));

        var utcDate = DateTime.UtcNow;
        Console.WriteLine(utcDate);
        Console.WriteLine(utcDate.ToLocalTime());

        var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");
        Console.WriteLine(timezoneAustralia);
        Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia));

        var timeszones = TimeZoneInfo.GetSystemTimeZones();
        foreach (var timezone in timeszones)
        {
            Console.WriteLine(timezone.Id);
            Console.WriteLine(timezone);
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
