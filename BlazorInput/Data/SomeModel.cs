namespace BlazorInput.Data
{
    using System;

    public class SomeModel
    {
        public string SomeString { get; set; }
        public double SomeNumber { get; set; }
        public DateTimeOffset SomeDate { get; set; }
        public string SomeSelect { get; set; }
        public string SomeText { get; set; }
        public DaysOfWeek Day { get; set; }
    }
}
