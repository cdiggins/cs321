using System.Security.Cryptography.X509Certificates;

namespace Todo
{
    public class Calendar 
    { 
        public List<Year> Years;
    }

    public class Year
    {
        public int Number;
        public List<Month> Months;
        public bool IsLeapYear => Number % 4 == 0;
    }

    public class Month
    {
        public Year Year;
        public int Number;
        public string Name;
        public List<Day> Days;
    }

    public enum DayOfWeek
    {
        Saturday = 0,
        Sunday = 1, 
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6,
    }

    public class Day
    {
        public Month Month;
        public int Number;
        public DayOfWeek DayOfWeek;
        public List<ScheduledItem> ScheduledItems;

        // https://artofmemory.com/blog/how-to-calculate-the-day-of-the-week/
        // https://www.almanac.com/how-find-day-week
        public DayOfWeek ComputeDayOfWeek()
        {
            var yy = Month.Year.Number % 100;
            var r = yy + yy / 4;
            r %= 7;
            var monthKey = 0;
            switch (Month.Number)
            {
                case 0: monthKey = 1; break;
                case 1: monthKey = 4; break;
                case 2: monthKey = 4; break;
                case 3: monthKey = 0; break;
                case 4: monthKey = 2; break;
                case 5: monthKey = 5; break;
                case 6: monthKey = 0; break;
                case 7: monthKey = 3; break;
                case 8: monthKey = 6; break;
                case 9: monthKey = 1; break;
                case 10: monthKey = 4; break;
                case 11: monthKey = 6; break;
            }
            r += monthKey;
            if (Month.Year.IsLeapYear && Month.Number <= 1)
                r -= 1;
            if (Month.Year.Number >= 1900 && Month.Year.Number < 2000)
            {

            }
            r += Number;
            return (DayOfWeek)(r % 7);   
        }

        public class ScheduledItem
    {
        public DateTime DateTime;
        public string Name;
        public string Description;
        public TimeSpan Duration;
    }

    public class Appointment : ScheduledItem 
    {
        public string Location;
    }
    
    public class Task : ScheduledItem 
    {
        public bool Completed;
    }    

    public class CheckList : ScheduledItem
    {
        public List<Task> Tasks;
    }
    
    public class Reminder : ScheduledItem 
    {
        public ScheduledItem OtherTask;
    }
    
    public class Meeting : ScheduledItem 
    {
        public List<string> Attendees;
    }

    public class FocusTime : ScheduledItem 
    { 
    }

    public static class Program
    {
        public static void ThreadStart(object? _)
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Ping!");
            }
        }

        public static void Main(string[] args)
        {
            var thread = new Thread(ThreadStart);
            thread.Start();
            var input = "";
            do
            {
                Console.WriteLine("Type in some input");
            }
            while ((input = Console.ReadLine()) != null);
        }
    }
}