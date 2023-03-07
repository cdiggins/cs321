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
    }

    public abstract class ScheduledItem
    {
        public DateTime DateTime;
        public bool IsPast() => DateTime.Now > DateTime;
        public abstract string ItemKind();
    }

    public class Appointment : ScheduledItem 
    {
        public string Location;
        public override string ItemKind() => "Appointment";
    }
    
    public class Task : ScheduledItem 
    {
        public bool Completed;
        public override string ItemKind() => "Task";
    }    

    public class Reminder : ScheduledItem 
    {
        public ScheduledItem OtherTask;
        public string ItemKind() => "Reminder";
    }

    public class CheckList : ScheduledItem
    {
        public List<Task> Tasks = new List<Task>();
        public string ItemKind() => "Check list";
    }

    public class Meeting : ScheduledItem 
    {
        public List<string> Attendees;
        public string ItemKind() => "Meeting";
    }

    public class FocusTime : ScheduledItem 
    {
        public string ItemKind() => "Focus";
    }

    public static class Program
    {
        public static void OutputItems_Long(IEnumerable<ScheduledItem> items)
        {
            foreach (var item in items)
            {
                var kind = "";
                if (item is Appointment)
                    kind = (item as Appointment).ItemKind();
                if (item is Meeting)
                    kind = (item as Meeting).ItemKind();
                if (item is Task)
                    kind = (item as Task).ItemKind();
                if (item is Reminder)
                    kind = (item as Reminder).ItemKind();
                Console.WriteLine($"Item {kind} is scheduled for {item.DateTime}");
            }
        }

        public static void OutputItems_NonVirtual(IEnumerable<ScheduledItem> items)
        {
            foreach (var item in items)
            {
                var kind = "";
                if (item is Appointment appointment)
                    kind = appointment.ItemKind();
                if (item is Meeting meeting)
                    kind = meeting.ItemKind();
                if (item is Task task)
                    kind = task.ItemKind();
                if (item is Reminder reminder)
                    kind = reminder.ItemKind();
                Console.WriteLine($"Item {kind} is scheduled for {item.DateTime}");
            }
        }

        public static void OutputItems(IEnumerable<ScheduledItem> items)
        {
            foreach (var item in items)
            {
                var kind = item.ItemKind();
                Console.WriteLine($"Item {kind} is scheduled for {item.DateTime}");
            }
        }

        public static void Main(string[] args)
        {
        }
    }
}