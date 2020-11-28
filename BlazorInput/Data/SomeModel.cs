namespace BlazorInput.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class SomeModel
    {
        public string SomeString { get; set; }
        public double SomeNumber { get; set; }
        public DateTimeOffset SomeDate { get; set; }
        public string SomeSelect { get; set; }
        public string SomeText { get; set; }

        public DaysOfWeek Day { get; set; }
    }

    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
